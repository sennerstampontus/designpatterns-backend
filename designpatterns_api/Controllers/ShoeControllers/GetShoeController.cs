using designpatterns_api.Entities;
using designpatterns_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace designpatterns_api.Controllers.ShoeControllers
{

    // Due to SRP I've created seperate controllers to match the actions. 
    // This controller is focused on GET. Even tho I'ts "GetAll" and "GetShoeById", I decided that It's okey.
    // As long as it's only GET Shoe.
    // This is also according to OCP, because when this is done, it's done.
    // There is no point of modify this working controller, 
    //if there is something else I would need from shoes, I create a new Controller for that purpose

    [Route("api/[controller]")]
    [ApiController]
    public class GetShoeController : ControllerBase
    {

        
        // Injects the IShoeService which is initialized in program.cs
        // this is to prevent High-level, Low-level imports. DIP.


        private readonly IShoeService _service;

        public GetShoeController(IShoeService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("/api/getshoes")]
        public async Task<ActionResult<IEnumerable<ShoeEntity>>> GetAll()
        {
            //List<ShoeEntity> shoes = await _context.Shoes.ToListAsync();

            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ShoeEntity>> GetShoeById(string id)
        {
            return Ok(await _service.GetAsync(id));
        }
    }


}
