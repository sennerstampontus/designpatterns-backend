using designpatterns_api.Entities;
using designpatterns_api.Models;

// This service is serving as a result of the Interface Seggregation and Dependency Inversion principles.
// This is instantiated through program.cs and injected in respective controller, so it's no wierd High/Low-level imports.
// And it also seperated the interfaces and follows ISP. I've choosen to do it this way
// mostly because it seems more readable and easier to follow what the code does.
// It almost follows every principle in SOLID, which in that case makes perfect sense to why it's easier to read and follow.

// *! This applies to IWatchService.cs as well

namespace designpatterns_api.Services
{
    public interface IShoeService
    {
        Task<ShoeEntity> CreateAsync(ShoeModel model);
        Task<IEnumerable<ShoeEntity>> GetAllAsync();
        Task<ShoeEntity> GetAsync(string id);
    }
}
