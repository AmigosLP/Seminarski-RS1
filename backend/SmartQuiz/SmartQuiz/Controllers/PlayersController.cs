using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartQuiz.Data;
using SmartQuiz.Helper;
using SmartQuiz.Models;
using System.Text.RegularExpressions;

namespace SmartQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly DataContext _context;

        public PlayersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Players
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            return await _context.Players.ToListAsync();
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = await _context.Players.FindAsync(id);

            if (player == null)
            {
                return NotFound();
            }

            return player;
        }

        // PUT: api/Players/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayer(int id, Player player)
        {
            if (id != player.PlayerID)
            {
                return BadRequest();
            }

            _context.Entry(player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(id))
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

        // POST: api/Players
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Player>> PostPlayer([FromBody]UserPlayer userPlayer)
        {
           //Provjera korisnika
           if (_context.Users.Any(o=>o.Username==userPlayer.Username))
           {
               return BadRequest(new
               {
                   Message = "Korisnicko ime vec postoji" 

               });
           }
            //Provjera email
            if (_context.Players.Any(o => o.Email == userPlayer.Email))
            {
                return BadRequest(new
                {
                    Message = "Email vec postoji"

                });
            }

            //Provjera sifre jacina
            var sifra = checkPasswordStrength(userPlayer.Password);
            if (!string.IsNullOrEmpty(sifra))
            {
                return BadRequest(new { Message = sifra.ToString() });
            }

            var user = new User
            {
                Username = userPlayer.Username,
                Password = userPlayer.Password
            };
            var gender = new Gender
            {
                GenderName = userPlayer.GenderName
            };
            var player = new Player
            {
                firstName = userPlayer.firstName,
                lastName = userPlayer.lastName,
                Email = userPlayer.Email,
                User = user,
                Gender = gender,
            };

            user.Password = PasswordHasher.HashPassword(user.Password);

            await _context.Users.AddAsync(user);
            await _context.Players.AddAsync(player);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                Message = "Registracija je uspjesna"
            });

        }
        private string checkPasswordStrength(string password)
        {
            StringBuilder sb = new StringBuilder();
            if (password.Length < 8)
            {
                sb.Append("Sifra mora da ima minimalno 8 znakova" + Environment.NewLine);
            }

            if (!(Regex.IsMatch(password, "[a-z]") &&
                  Regex.IsMatch(password, "[A-Z]") &&
                  Regex.IsMatch(password, "[0-9]")))
            {
                sb.Append("Sifra mora da sadrzi minimu jedno veliko slovo i brojeve" + Environment.NewLine);
            }

            if (!(Regex.IsMatch(password, "[<,>,@,!,#,$,%,^,&,*,-,+,/,|,~,=]")))
            {
                sb.Append("Sifra mora da sadrzi specijalne karaktere");
            }
            return sb.ToString();
        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }

            _context.Players.Remove(player);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerExists(int id)
        {
            return _context.Players.Any(e => e.PlayerID == id);
        }
    }
}
