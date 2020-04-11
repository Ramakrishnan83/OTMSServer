using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OTMS.Context;

namespace OTMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripDetailsController : ControllerBase
    {
        private readonly UserDbContext _context;

        public TripDetailsController(UserDbContext context)
        {
            _context = context;
        }

        // GET: api/TripDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TripDetails>>> GetTripDetails()
        {
            return await _context.TripDetails.ToListAsync();
        }

        // GET: api/TripDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TripDetails>>> GetTripDetails(int id)
        {
            var tripDetails = await _context.TripDetails.Where(x => x.User_Id == id).ToListAsync();

            if (tripDetails == null)
            {
                return NotFound();
            }

            return tripDetails;
            //return await _context.TripDetails.FindAsync(id);

        }

        // PUT: api/TripDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTripDetails(int id, TripDetails tripDetails)
        {
            if (id != tripDetails.Trip_id)
            {
                return BadRequest();
            }

            _context.Entry(tripDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TripDetailsExists(id))
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

        // POST: api/TripDetails
        [HttpPost]
        public async Task<ActionResult<TripDetails>> PostTripDetails(TripDetails tripDetails)
        {
            _context.TripDetails.Add(tripDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTripDetails", new { id = tripDetails.Trip_id }, tripDetails);
        }

        // DELETE: api/TripDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TripDetails>> DeleteTripDetails(int id)
        {
            var tripDetails = await _context.TripDetails.FindAsync(id);
            if (tripDetails == null)
            {
                return NotFound();
            }

            _context.TripDetails.Remove(tripDetails);
            await _context.SaveChangesAsync();

            return tripDetails;
        }

        private bool TripDetailsExists(int id)
        {
            return _context.TripDetails.Any(e => e.Trip_id == id);
        }
    }
}
