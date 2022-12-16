using designpatterns_api.Data;
using designpatterns_api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLib.Factories;
using SharedLib.Models;

namespace designpatterns_api.Controllers.WatchControllers
{

    // Due to SRP I've created seperate controllers to match the actions. 
    // This controller is focused on POST.
    // As long as it's only POST/CREATE a Watch, this controller is fine.

    [Route("api/[controller]")]
    [ApiController]
    public class CreateWatchController : ControllerBase
    {
        private readonly SqlContext _context;

        public CreateWatchController(SqlContext context)
        {
            _context = context;
        }

       
        [HttpPost]
     
        public async Task<ActionResult<WatchEntity>> Create(WatchModel model)
        {
            var watch = WatchFactory.Create( model.Title, model.Description, model.Price, model.Category, model.IsWaterproof, model.WatchType, model.Wristband, model.Rating, model.ImageUrl, model.IsOnSale, model.SaleProcent, model.CalculateSalePrice(model.Price, model.SaleProcent));
         
            _context.Watches.Add(watch);
            await _context.SaveChangesAsync();
            
            return Created("Created", watch);
        }
    }
}
