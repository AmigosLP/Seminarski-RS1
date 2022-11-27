using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartQuiz.Data;
using SmartQuiz.Helper;
using SmartQuiz.Models;

namespace SmartQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportersController : ControllerBase
    {
        private readonly DataContext _context;

        public SupportersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Supporters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Supporter>>> GetSupporters()
        {
            return await _context.Supporters.ToListAsync();
        }

        // GET: api/Supporters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Supporter>> GetSupporter(int id)
        {
            var supporter = await _context.Supporters.FindAsync(id);

            if (supporter == null)
            {
                return NotFound();
            }

            return supporter;
        }

        // PUT: api/Supporters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupporter(int id, Supporter supporter)
        {
            if (id != supporter.SupporterID)
            {
                return BadRequest();
            }

            _context.Entry(supporter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupporterExists(id))
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

        // POST: api/Supporters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Supporter>> PostSupporter([FromBody]UserPlayer userSupporter)
        {
            //Provjera supportera da li postoji njegov username i pw postoji vec u bazi
            if(_context.Users.Any(s=>s.Username==userSupporter.Username))
            {
                return BadRequest(new
                {
                    Message="Korisnicko ime vec postoji"

                });
                   
            }
            //Provjera email-a da li postoji kod supporter-a
            if (_context.Supporters.Any(o => o.Email == userSupporter.Email))
            {
                return BadRequest(new
                {
                    Message = "Email vec postoji"

                });
            }
            //Provjera jacine i duzine passworda
            var password = CheckPassword(userSupporter.Password);
            if(!string.IsNullOrEmpty(password))
            {
                return BadRequest(new { Message = password.ToString() });
            }

            var user = new User
            {
                Username = userSupporter.Username,
                Password = userSupporter.Password
            };

            var gender = new Gender
            {
                GenderName = userSupporter.GenderName,
            };

            var supporter = new Supporter
            {
                firstName = userSupporter.firstName,
                lastName = userSupporter.lastName,
                Email = userSupporter.Email,
                User = user,
                Gender = gender,
            };
            user.Password = PasswordHasher.HashPassword(user.Password);
            await _context.Users.AddAsync(user);
            await _context.Supporters.AddAsync(supporter);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                Message="Supporter uspjesno dodan."
            });


        }
        //Regex za provjeru sifre koja se poziva gore u navedenoj metodi
        private string CheckPassword(string password)
        {
            StringBuilder sb=new StringBuilder();
            if(password.Length<8)
            {
                sb.Append("Molimo Vas da sifra bude sastava minimalno 8 znakovni karaktera");
            }
            if(!(Regex.IsMatch(password,"[a-z]")&&
                Regex.IsMatch(password,"[A-Z]")&&
                Regex.IsMatch(password,"[0-9]")))
            {
                sb.Append("Sifra mora da sadrzi minimum jedno veliko slovo i brojeve " + Environment.NewLine);
            }
            return sb.ToString();
        }

        // DELETE: api/Supporters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupporter(int id)
        {
            var supporter = await _context.Supporters.FindAsync(id);
            if (supporter == null)
            {
                return NotFound();
            }

            _context.Supporters.Remove(supporter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupporterExists(int id)
        {
            return _context.Supporters.Any(e => e.SupporterID == id);
        }

    }
}
