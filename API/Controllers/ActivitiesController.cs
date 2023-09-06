using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public  ActivitiesController(DataContext context) //we are using a dependency injector to inject the class
        { 
            _context = context;
        }

        [HttpGet] //api/activities --//when someone comes to this site they can use api/activites
        public async Task<ActionResult<List<Activity>>> GetActivities() //here is where we specify what we get back inside the response body
        {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] //api/activities/blablabla
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}