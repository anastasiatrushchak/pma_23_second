using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorSongsController : ControllerBase
    {
        private readonly AuthorSongContext _context;

        public AuthorSongsController(AuthorSongContext context)
        {
            _context = context;
        }

        // GET: api/AuthorSongs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorSong>>> GetAuthorsSongs()
        {
            return await _context.AuthorsSongs.ToListAsync();
        }

        // GET: api/AuthorSongs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorSong>> GetAuthorSong(int id)
        {
            var authorSong = await _context.AuthorsSongs.FindAsync(id);

            if (authorSong == null)
            {
                return NotFound();
            }

            return authorSong;
        }

        // PUT: api/AuthorSongs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthorSong(int id, AuthorSong authorSong)
        {
            if (id != authorSong.ID)
            {
                return BadRequest();
            }

            _context.Entry(authorSong).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorSongExists(id))
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

        // POST: api/AuthorSongs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AuthorSong>> PostAuthorSong(AuthorSong authorSong)
        {
            _context.AuthorsSongs.Add(authorSong);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuthorSong", new { id = authorSong.ID }, authorSong);
        }

        // DELETE: api/AuthorSongs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthorSong(int id)
        {
            var authorSong = await _context.AuthorsSongs.FindAsync(id);
            if (authorSong == null)
            {
                return NotFound();
            }

            _context.AuthorsSongs.Remove(authorSong);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AuthorSongExists(int id)
        {
            return _context.AuthorsSongs.Any(e => e.ID == id);
        }
    }
}
