using designpatterns_api.Data;
using designpatterns_api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace designpatterns_api.Controllers.WatchControllers

    // Due to SRP I've created seperate controllers to match the actions. 
    // This controller is focused on GET. Even tho I'ts "GetAll" and "GetWatchById", I decided that It's okey.
    // As long as it's only GET Watch.
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetWatchController : ControllerBase
    {
        private readonly SqlContext _context;

        public GetWatchController(SqlContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("/api/getwatches")]
        public async Task<ActionResult<IEnumerable<WatchEntity>>> GetAll()
        {
            List<WatchEntity> watches = await _context.Watches.ToListAsync();

            return Ok(watches);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WatchEntity>> GetWatchById(string id)
        {
            var watch = await _context.Watches.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(watch);
        }
    }
}
