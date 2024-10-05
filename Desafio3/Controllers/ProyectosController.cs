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
    public class ProyectosController : ControllerBase
    {
        private readonly ProyectosDBContext _context;

        public ProyectosController(ProyectosDBContext context)
        {
            _context = context;
        }

        // GET: api/Proyectos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProyectoT>>> GetProyecto()
        {
            return await _context.Proyecto.ToListAsync();
        }

        // GET: api/Proyectos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProyectoT>> GetProyectoT(int id)
        {
            var proyectoT = await _context.Proyecto.FindAsync(id);

            if (proyectoT == null)
            {
                return NotFound();
            }

            return proyectoT;
        }

        // PUT: api/Proyectos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyectoT(int id, ProyectoT proyectoT)
        {
            if (id != proyectoT.Id)
            {
                return BadRequest();
            }

            _context.Entry(proyectoT).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProyectoTExists(id))
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

        // POST: api/Proyectos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProyectoT>> PostProyectoT(ProyectoT proyectoT)
        {
            _context.Proyecto.Add(proyectoT);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProyectoT", new { id = proyectoT.Id }, proyectoT);
        }

        // DELETE: api/Proyectos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProyectoT(int id)
        {
            var proyectoT = await _context.Proyecto.FindAsync(id);
            if (proyectoT == null)
            {
                return NotFound();
            }

            _context.Proyecto.Remove(proyectoT);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProyectoTExists(int id)
        {
            return _context.Proyecto.Any(e => e.Id == id);
        }
    }
}
