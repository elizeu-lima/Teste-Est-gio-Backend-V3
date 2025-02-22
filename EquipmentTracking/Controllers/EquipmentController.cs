using EquipmentTracking.Data;
using EquipmentTracking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EquipmentTracking.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EquipmentController : ControllerBase
{
    private readonly AppDbContext _context;

    public EquipmentController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Equipment>>> GetEquipments()
    {
        return await _context.Equipments.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Equipment>> GetEquipment(int id)
    {
        var equipment = await _context.Equipments.FindAsync(id);
        if (equipment == null)
        {
            return NotFound();
        }
        return equipment;
    }

    [HttpPost]
    public async Task<ActionResult<Equipment>> PostEquipment(Equipment equipment)
    {
        _context.Equipments.Add(equipment);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetEquipment), new { id = equipment.Id }, equipment);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutEquipment(int id, Equipment equipment)
    {
        if (id != equipment.Id)
        {
            return BadRequest();
        }

        _context.Entry(equipment).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEquipment(int id)
    {
        var equipment = await _context.Equipments.FindAsync(id);
        if (equipment == null)
        {
            return NotFound();
        }

        _context.Equipments.Remove(equipment);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
