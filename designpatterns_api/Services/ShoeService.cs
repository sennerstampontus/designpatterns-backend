using designpatterns_api.Data;
using designpatterns_api.Entities;
using designpatterns_api.Interfaces;
using designpatterns_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace designpatterns_api.Services
{

    

    public class ShoeService : IShoeService
    {
        private readonly SqlContext _ctx;
        private readonly IShoeFactory _factory;

        public ShoeService(SqlContext ctx, IShoeFactory factory)
        {
            _ctx = ctx;
            _factory = factory;
        }

        public async Task<ShoeEntity> CreateAsync(ShoeModel model)
        {
            var shoeEntity = _factory.Create(model.Title, model.Description, model.Price, model.Category, model.Heels, model.Rating, model.ImageUrl, model.IsOnSale, model.SaleProcent, model.CalculateSalePrice(model.Price, model.SaleProcent));

            _ctx.Add(shoeEntity);
            await _ctx.SaveChangesAsync();

            return shoeEntity;
        }

        public async Task<IEnumerable<ShoeEntity>> GetAllAsync()
        {
            List<ShoeEntity> shoes = _factory.ShoeList();
            foreach(var shoe in await _ctx.Shoes.ToListAsync())
            {
                shoes.Add(_factory.Shoe(shoe));
            }

            return shoes;
        }

        public async Task<ShoeEntity> GetAsync(string id)
        {
            return await _ctx.Shoes.FindAsync(id);
        }
    }
}
