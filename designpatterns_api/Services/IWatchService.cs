using designpatterns_api.Entities;
using designpatterns_api.Models;

namespace designpatterns_api.Services
{
    public interface IWatchService
    {
        Task<WatchEntity> CreateAsync(WatchModel model);
        Task<IEnumerable<WatchEntity>> GetAllAsync();
        Task<WatchEntity> GetAsync(string id);
    }
}
