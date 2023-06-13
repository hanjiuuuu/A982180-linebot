using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace a982180_linebot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class npcController : ControllerBase
    {
        // GET: api/npc
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/npc/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/npc
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/npc/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/npc/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
