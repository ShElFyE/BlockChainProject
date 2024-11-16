using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wallet2.Services;

[Route("api/[controller]")]
[ApiController]
public class MyEntitiesController : ControllerBase
{
    private readonly IMyEntityService _service;

    public MyEntitiesController(IMyEntityService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MyEntity>>> GetEntities()
    {
        var entities = await _service.GetAllEntitiesAsync();
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MyEntity>> GetEntity(int id)
    {
        var entity = await _service.GetEntityByIdAsync(id);
        if (entity == null) return NotFound();
        return Ok(entity);
    }

    [HttpPost]
    public async Task<ActionResult<MyEntity>> CreateEntity(MyEntity entity)
    {
        await _service.CreateEntityAsync(entity);
        return CreatedAtAction(nameof(GetEntity), new { id = entity.Id }, entity);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEntity(int id, MyEntity entity)
    {
        if (id != entity.Id) return BadRequest();
        await _service.UpdateEntityAsync(entity);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEntity(int id)
    {
        await _service.DeleteEntityAsync(id);
        return NoContent();
    }
}
