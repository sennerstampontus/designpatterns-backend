using designpatterns_api.Data;
using designpatterns_api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedLib.Factories;
using SharedLib.Models;

namespace designpatterns_api.Controllers.ShoeControllers
{

    // Due to SRP I've created seperate controllers to match the actions. 
    // This controller is focused on POST.
    // As long as it's only POST/CREATE a Shoe, this controller is fine.

    [Route("api/[controller]")]
    [ApiController]
    public class CreateShoeController : ControllerBase
    {
        private readonly SqlContext _context;

        public CreateShoeController(SqlContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<ShoeEntity>> Create(ShoeModel model)
        {


            var _shoe = ShoeFactory.Create( model.Title, model.Description, model.Price, model.Category, model.Heels, model.Rating, model.ImageUrl, model.IsOnSale, model.SaleProcent, model.CalculateSalePrice(model.Price, model.SaleProcent));

            _context.Shoes.Add(_shoe);
            await _context.SaveChangesAsync();



            return Created("Created", _shoe);
        }
    }
}
