using AccountService.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccountService.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ConsumersController : ControllerBase
    {
        // GET: api/v1/<ConsumersController>
        [HttpGet]
        public ActionResult< IEnumerable <Consumer> > Get()
        {
            return new List<Consumer>()
            {
                new Consumer()
                {
                    Id = 111,
                    Firstname = "Jeremy",
                    Surname = "Cook",
                    Age = 20
                },
                new Consumer()
                {
                    Id = 112,
                    Firstname = "Bob",
                    Surname = "Smith",
                    Age = 43
                },
                new Consumer()
                {
                    Id = 113,
                    Firstname = "John",
                    Surname = "Doe",
                    Age = 21
                },
                new Consumer()
                {
                    Id = 114,
                    Firstname = "Mary",
                    Surname = "Doe",
                    Age = 45
                }
            };
        }

        // GET api/v1/<ConsumersController>/5
        [HttpGet("{id}")]
        public ActionResult<Consumer> Get(int id)
        {
            return new Consumer()
            {
                Id = id,
                Firstname = "Jeremy",
                Surname = "Cook",
                Age = 20
            };
        }

        // POST api/v1/<ConsumersController>
        [HttpPost]
        public ActionResult<Consumer> Post([FromBody] Consumer consumer)
        {
            return new Consumer()
            {
                Id = 100,
                Firstname = consumer.Firstname,
                Surname = consumer.Surname,
                Age = consumer.Age
            };
        }

        // PUT api/v1/<ConsumersController>/5
        [HttpPut("{id}")]
        public ActionResult<Consumer> Put(int id, [FromBody] Consumer consumer)
        {
            return new Consumer()
            {
                Id = id,
                Firstname = consumer.Firstname,
                Surname = consumer.Surname,
                Age = consumer.Age
            };
        }

        // DELETE api/v1/<ConsumersController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return true;
        }
    }
}
