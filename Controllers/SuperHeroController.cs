using System;
using Microsoft.AspNetCore.Mvc;
using SuperHeroApi.Models;

namespace SuperHeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
        {
           new SuperHero{Id = 1, Name="Spider Main", FirstName = "Peter", LastName = "Parker"},
           new SuperHero{Id = 2, Name="Iron Main", FirstName = "Tony", LastName = "Stark"}
        };

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return Ok(superHeroes);
        }
        [HttpGet]
        public  async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {

            var hero = superHeroes.Find(x => x.Id == id);
            return Ok(hero);
        }

    }
}

