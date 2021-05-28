using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    { 
        private readonly DataContext _context;
        public ValuesController(DataContext context){
            //this.context =context;
            this._context=context;
        }
        // GET api/values
        [HttpGet]
        public async Task <ActionResult<IEnumerable<Value>>> Get()
        {
            var values=await _context.Values.ToListAsync();
            //return new string[] { "value1", "value2" };
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Value>>GetAction(int id)
        {
            var valuee = await _context.Values.FindAsync(id);
            return Ok(valuee);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        /*public async Task<ActionResult<Value>>GetAction(int id)
        {
            var valuee = await _context.Values.FindAsync(id);
            return Ok(valuee);
        }*/

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
