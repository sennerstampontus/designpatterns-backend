using designpatterns_api.Data;
using designpatterns_api.Entities;
using designpatterns_api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace designpatterns_api.Controllers.WatchControllers

    // Due to SRP I've created seperate controllers to match the actions. 
    // This controller is focused on GET. Even tho I'ts "GetAll" and "GetWatchById", I decided that It's okey.
    // As long as it's only GET Watch.
    // This is also according to OCP, because when this is done, it's done.
    // There is no point of modify this working controller, 
    //if there is something else I would need from shoes, I create a new Controller for that purpose

{
    [Route("api/[controller]")]
    [ApiController]
    public class GetWatchController : ControllerBase
    {

        // Injects the IWatchService which is initialized in program.cs
        // this is to prevent High-level, Low-level imports. DIP.


        private readonly IWatchService _service;

        public GetWatchController(IWatchService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("/api/getwatches")]
        public async Task<ActionResult<IEnumerable<WatchEntity>>> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WatchEntity>> GetWatchById(string id)
        {
            return Ok(await _service.GetAsync(id));
        }
    }
}
