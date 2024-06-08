using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        // GET: api/People/List
        [HttpGet(Name = "List")]
        public List<Person> List(string FirstName, string LastName)
        {
            List<Person> people = new List<Person>();
            for (int i = 1; i <= 100; i++)
            {
                people.Add(new Person
                {
                    Id = i,
                    FirstName = $"Jhoselin{i}",
                    LastName = $"Ponce{i}"
                });
            }
            return people;
        }

        //endpoint de tipo post con nombre Listar2
        //el navegador esta preparado para soportar Get nada mas
        [HttpPost(Name = "Listar2")]
        public List<Person> Listar2([FromBody] Person filter)
        {
            List<Person> people = new List<Person>();
            for (int i = 1; i <= 100; i++)
            {
                people.Add(new Person
                {
                    Id = i,
                    FirstName = $"Jhoselin{i}",
                    LastName = $"Ponce{i}"
                });
            }

            if (!string.IsNullOrEmpty(filter.FirstName))
            {
                people = people.Where(p => p.FirstName.Contains(filter.FirstName)).ToList();
            }

            if (!string.IsNullOrEmpty(filter.LastName))
            {
                people = people.Where(p => p.LastName.Contains(filter.LastName)).ToList();
            }

            return people;
        }
    }
}
