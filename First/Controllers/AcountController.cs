using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.Data;
using Microsoft.AspNetCore.Mvc;
using First.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace First.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcountController : Controller
    {
        private readonly MyDbContext _context;
        public AcountController(MyDbContext context)
        {
            _context = context;

        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<List<Acount>>> Get()
        {
            return Ok(await _context.Acounts.ToListAsync());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Acount>>> Get(int id)
        {
            var acount = await _context.Acounts.FindAsync(id);
            if (acount == null)
                return BadRequest("This acount not found");
            return Ok(acount);
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<List<Acount>>> AddAcount(Acount acount)
        {

            _context.Acounts.Add(acount);
            await _context.SaveChangesAsync();

            return Ok(await _context.Acounts.ToListAsync());
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<ActionResult<List<Acount>>> UpdateAcount(Acount acount)
        {
            var dbacount = await _context.Acounts.FindAsync(acount.ID);
            if (dbacount == null)
                return BadRequest("This acount not found.");
            dbacount.FNAME = acount.FNAME;
            dbacount.LNAME = acount.LNAME;
            dbacount.AGE = acount.AGE;
            dbacount.EMAIL= acount.EMAIL;

            await _context.SaveChangesAsync();

            return Ok(await _context.Acounts.ToListAsync());

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Acount>>> DeleteAcount(int id)
        {
            var acount = await _context.Acounts.FindAsync(id);
            if (acount == null)
                return BadRequest("This acount not found.");
            _context.Acounts.Remove(acount);
            await _context.SaveChangesAsync();
            return Ok(await _context.Acounts.ToListAsync());
        }
    }
}

