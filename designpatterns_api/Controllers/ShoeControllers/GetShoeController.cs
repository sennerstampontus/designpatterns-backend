using designpatterns_api.Data;
using designpatterns_api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace designpatterns_api.Controllers.ShoeControllers
{

    // Due to SRP I've created seperate controllers to match the actions. 
    // This controller is focused on GET. Even tho I'ts "GetAll" and "GetShoeById", I decided that It's okey.
    // As long as it's only GET Shoe.

    [Route("api/[controller]")]
    [ApiController]
    public class GetShoeController : ControllerBase
    {
        private readonly SqlContext _context;

        public GetShoeController(SqlContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("/api/getshoes")]
        public async Task<ActionResult<IEnumerable<ShoeEntity>>> GetAll()
        {
            List<ShoeEntity> shoes = await _context.Shoes.ToListAsync();

            return Ok(shoes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ShoeEntity>> GetShoeById(string id)
        {
            var shoe = await _context.Shoes.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(shoe);
        }
    }


}
