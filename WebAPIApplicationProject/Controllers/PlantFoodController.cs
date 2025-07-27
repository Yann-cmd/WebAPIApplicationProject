using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApplicationProject.Models;

namespace WebAPIApplicationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PlantFoodController : ControllerBase
    {
        private readonly PlantFoodContext _context;

        public PlantFoodController(PlantFoodContext context)
        {
            _context = context;
        }

        // GET: api/PlantFood
        /// <summary>
        /// Récupère la liste des fruits et légumes.
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<PlantFood>>> GetPlantFoods()
        {
            //return await _context.PlantFoods.ToListAsync();
            return await Task.FromResult(Ok(PlantFoodConstants.DefaultPlantFood));
        }

        // GET: api/PlantFood/5
        /// <summary>
        /// Récupère un fruit ou légume par son id.
        /// </summary>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<PlantFood>> GetPlantFood(long id)
        {
            var plantFood = await _context.PlantFoods.FindAsync(id);

            if (plantFood == null)
            {
                return NotFound();
            }

            return plantFood;
        }

        // PUT: api/PlantFood/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// Met à jour un fruit ou légume par son id.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlantFood(long id, PlantFood plantFood)
        {
            if (id != plantFood.Id)
            {
                return BadRequest();
            }

            _context.Entry(plantFood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlantFoodExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Aliment correctement mis à jour.");
        }

        // POST: api/PlantFood
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// Ajoute un fruit ou légume.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<PlantFood>> PostPlantFood(PlantFood plantFood)
        {
            _context.PlantFoods.Add(plantFood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlantFood", new { id = plantFood.Id }, plantFood);
        }

        // DELETE: api/PlantFood/5
        /// <summary>
        /// Supprime un fruit ou légume par son id.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlantFood(long id)
        {
            var plantFood = await _context.PlantFoods.FindAsync(id);
            if (plantFood == null)
            {
                return NotFound();
            }

            _context.PlantFoods.Remove(plantFood);
            await _context.SaveChangesAsync();

            return Ok("Aliment correctement supprimé.");
        }

        private bool PlantFoodExists(long id)
        {
            return _context.PlantFoods.Any(e => e.Id == id);
        }
    }
}
