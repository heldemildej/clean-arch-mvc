using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchMvc.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _categoryService.GetCategoriesAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _categoryService.GetByIdAsync(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryDTO category)
        {
            if (category == null)
                return BadRequest();

            await _categoryService.AddAsync(category);
            return CreatedAtAction(nameof(Get), new { id = category.Id }, category);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] CategoryDTO category)
        {
            if (category == null)
                return BadRequest();

            try
            {
                await _categoryService.UpdateAsync(category);
                return Ok(category);
            }
            catch (ApplicationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _categoryService.RemoveAsync(id);
                return NoContent();
            }
            catch (ApplicationException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}