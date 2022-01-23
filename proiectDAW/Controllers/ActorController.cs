using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proiectDAW.Models.Many_to_Many;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        public static List<Actor> actors = new List<Actor>
        {
            new Actor {Id = Guid.NewGuid(), Nume = "Popa", Prenume = "Ana", Varsta = 16},
            new Actor {Id = Guid.NewGuid(), Nume = "Pop", Prenume = "Andrei", Varsta = 17},
            new Actor {Id = Guid.NewGuid(), Nume = "Cristea", Prenume = "Anca", Varsta = 19},
            new Actor {Id = Guid.NewGuid(), Nume = "Preda", Prenume = "Marius", Varsta = 22},
            new Actor {Id = Guid.NewGuid(), Nume = "Petcu", Prenume = "Cristiana", Varsta = 23}
        };

        //AFISARE DATE EXISTENTE
        [HttpGet("getActori")] //nume end point - ceva sugestiv
        public List<Actor> Get()
        {
            return actors;
        }


        [HttpGet("getActoriById")]
        public Actor GetActorById (int id)
        {
            return actors.FirstOrDefault(a => a.Id.Equals(id));
        }

        //filtrare dupa nume si varsta

        [HttpGet("Filter/{nume}/{varsta}")]
        public Actor GetWithFilters (string nume, int varsta)
        {
            return actors.FirstOrDefault(a => a.Nume.Equals(nume) && a.Varsta.Equals(varsta));
        }

        //cu ? in URL
        [HttpGet("fromQuery")]
        public Actor GetByVarstaFromQuerry ([FromQuery] int varsta)
        {
            return actors.FirstOrDefault(a => a.Varsta.Equals(varsta));
        }

        [HttpGet("fromHeader")]
        public Actor GetByVarstaFromHeader ([FromHeader]int varsta)
        {
            return actors.FirstOrDefault(a => a.Varsta.Equals(varsta));
        }

        //CREARE DATE
        [HttpPost]
        public IActionResult Add(Actor actor)
        {
            actors.Add(actor);
            return Ok(actors);
        }

        [HttpPost("fromForm ")]
        public IActionResult AddFromForm([FromForm]Actor actor)
        {
            actors.Add(actor);
            return Ok(actors);

        }

        //UPDATE
        [HttpPut("Update")]
        public IActionResult Update(Actor actor)
        {
            var actorIndex = actors.FindIndex((Actor _actor) => _actor.Id.Equals(actor.Id));
            actors[actorIndex] = actor;
            return Ok(actors);
        }

        //DELETE
        [HttpDelete("Sterge")]
        public IActionResult Delete(Actor actor)
        {
            var actorIndex = actors.FindIndex((Actor _actor) => _actor.Id.Equals(actor.Id));
            actors[actorIndex] = actor;
            actors.Remove(actors[actorIndex]);
            return Ok(actors);
        }
    }
}
