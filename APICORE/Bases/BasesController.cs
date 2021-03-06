﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICORE.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICORE.Bases
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasesController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;

        public BasesController(TRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<TEntity>> Get() => await _repository.GetAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var get = await _repository.GetAsync(id);
            if (get == null)
            {
                return NotFound();
            }
            return Ok(get);
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await _repository.PostAsync(entity);
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, TEntity entity)
        {
            if(id != entity.Id)
            {
                return BadRequest();
            }
            await _repository.PullAsync(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var delete = await _repository.DeleteAsync(id);
            if(delete == null)
            {
                return NotFound();
            }
            return delete;
        }
    }
}