using Microsoft.AspNetCore.Mvc;
using dotnetCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActorController : ControllerBase
    {
       
        [HttpGet(Name = "GetAllActors")]
        public IEnumerable<Actor> Get()
        {

            List<Actor> actors;
            using (var context = new sakilaContext())
            {
                actors = context.Actors.ToList();
            }

            return actors;
        }
    }
}
