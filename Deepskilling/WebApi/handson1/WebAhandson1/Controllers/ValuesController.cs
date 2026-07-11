using Microsoft.AspNetCore.Mvc;

namespace WebAhandson1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        static List<string> values = new List<string>()
        {
            "Apple",
            "Banana",
            "Mango"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0 || id >= values.Count)
                return NotFound();

            return Ok(values[id]);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            values.Add(value);
            return Ok("Value Added Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest();

            values[id] = value;
            return Ok("Value Updated Successfully");
        }

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