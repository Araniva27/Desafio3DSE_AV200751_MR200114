using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Desafio3.Models;

namespace Desafio3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        private readonly ProyectosDBContext _context;

        public EquiposController(ProyectosDBContext context)
        {
            _context = context;
        }

        // GET: api/Equipos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipoT>>> GetEquipo()
        {
            return await _context.Equipo.ToListAsync();
        }

        // GET: api/Equipos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EquipoT>> GetEquipoT(int id)
        {
            var equipoT = await _context.Equipo.FindAsync(id);

            if (equipoT == null)
            {
                return NotFound();
            }

            return equipoT;
        }

        // PUT: api/Equipos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipoT(int id, EquipoT equipoT)
        {
            if (id != equipoT.Id)
            {
                return BadRequest();
            }

            _context.Entry(equipoT).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipoTExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Equipos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EquipoT>> PostEquipoT(EquipoT equipoT)
        {
            _context.Equipo.Add(equipoT);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipoT", new { id = equipoT.Id }, equipoT);
        }

        // DELETE: api/Equipos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEquipoT(int id)
        {
            var equipoT = await _context.Equipo.FindAsync(id);
            if (equipoT == null)
            {
                return NotFound();
            }

            _context.Equipo.Remove(equipoT);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EquipoTExists(int id)
        {
            return _context.Equipo.Any(e => e.Id == id);
        }
    }
}
