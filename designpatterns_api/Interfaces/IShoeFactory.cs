using designpatterns_api.Entities;

namespace designpatterns_api.Interfaces
{
    public interface IShoeFactory
    {
        ShoeEntity Create(string title, string description, decimal price, string category, string? heels, int? rating, string imageUrl, bool isOnSale, int saleProcent, decimal salePrice);
        ShoeEntity Shoe(ShoeEntity shoeEntity);
        List<ShoeEntity> ShoeList();

    }
}