using designpatterns_api.Data;
using designpatterns_api.Entities;
using designpatterns_api.Interfaces;
using designpatterns_api.Models;
using designpatterns_api.Services;
using Microsoft.AspNetCore.Mvc;


namespace designpatterns_api.Controllers.ShoeControllers
{

    // Due to SRP I've created seperate controllers to match the actions. 
    // This controller is focused on POST.
    // As long as it's only POST/CREATE a Shoe, this controller is fine.
    // This is also according to OCP, because when this is done, it's done.
    // There is no point of modify this working controller, 
    //if there is something else I would need from shoes, I create a new Controller for that purpose

    [Route("api/[controller]")]
    [ApiController]
    public class CreateShoeController : ControllerBase
    {

        // Injects the IShoeService which is initialized in program.cs
        // this is to prevent High-level, Low-level imports. DIP.


        private readonly IShoeService _service;

        public CreateShoeController(IShoeService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<ShoeEntity>> Create(ShoeModel model)
        {


            return Created("", await _service.CreateAsync(model));
        }
    }
}
