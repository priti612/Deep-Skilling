using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        static List<string> values = new List<string>
        {
            "Apple",
            "Banana",
            "Mango"
        };

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(values);
        }

        // GET: api/values/1
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= values.Count)
                return NotFound();

            return Ok(values[id]);
        }

        // POST: api/values
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            values.Add(value);
            return Ok("Value Added Successfully");
        }

        // PUT: api/values/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest();

            values[id] = value;
            return Ok("Value Updated Successfully");
        }

        // DELETE: api/values/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest();

            values.RemoveAt(id);
            return Ok("Value Deleted Successfully");
        }
    }
}