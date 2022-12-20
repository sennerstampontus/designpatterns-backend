using designpatterns_api.Data;
using designpatterns_api.Entities;
using designpatterns_api.Interfaces;
using designpatterns_api.Models;
using Microsoft.EntityFrameworkCore;

namespace designpatterns_api.Services
{
    public class WatchService : IWatchService
    {

        private readonly SqlContext _ctx;
        private readonly IWatchFactory _factory;

        public WatchService(SqlContext ctx, IWatchFactory factory)
        {
            _ctx = ctx;
            _factory = factory;
        }

        public async Task<WatchEntity> CreateAsync(WatchModel model)
        {
            var watchEntity = _factory.Create(model.Title, model.Description, model.Price, model.Category, model.IsWaterproof, model.WatchType, model.Wristband, model.Rating, model.ImageUrl, model.IsOnSale, model.SaleProcent, model.CalculateSalePrice(model.Price, model.SaleProcent));

            _ctx.Watches.Add(watchEntity);
            await _ctx.SaveChangesAsync();

            return watchEntity;
        }

        public async Task<IEnumerable<WatchEntity>> GetAllAsync()
        {
            List<WatchEntity> watches = _factory.WatchList();
            foreach(var watch in await _ctx.Watches.ToListAsync())
            {
                watches.Add(_factory.Watch(watch));
            }

            return watches;
        }

        public async Task<WatchEntity> GetAsync(string id)
        {
            return await _ctx.Watches.FindAsync(id);
        }
    }
}
