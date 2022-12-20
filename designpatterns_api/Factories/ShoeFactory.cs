using designpatterns_api.Entities;
using designpatterns_api.Interfaces;

namespace designpatterns_api.Factories;


/// <summary>
/// 
/// ShoeFactory is used to create an instance of Shoe model when creating a shoe to database. 
/// This so avoid to create an instance in the controller. Part of "Dependency Inversion Principle"
///
/// It could seem to be a repeated action to have two, almost identical factories. But I rather use SRP in this case and split the factories into two/three. 
/// And have it a little bit cleaner in the controller 
/// 
/// </summary>
public class ShoeFactory : IShoeFactory
{
    public ShoeEntity Create(string title, string description, decimal price, string category, string? heels, int? rating, string imageUrl, bool isOnSale, int saleProcent, decimal salePrice)
    {
        return new ShoeEntity() { Title = title, Description = description, Price = price, Category = category, ImageUrl = imageUrl, Rating = rating, Heels = heels, IsOnSale = isOnSale, SaleProcent = saleProcent, SalePrice = salePrice };
    }

    public ShoeEntity Shoe(ShoeEntity shoeEntity)
    {
        return new ShoeEntity()
        {
            Id = shoeEntity.Id,
            Title = shoeEntity.Title,
            Description = shoeEntity.Description,
            Price = shoeEntity.Price,
            Category = shoeEntity.Category,
            ImageUrl = shoeEntity.ImageUrl,
            Rating = shoeEntity.Rating,
            Heels = shoeEntity.Heels,
            IsOnSale= shoeEntity.IsOnSale,
            SaleProcent= shoeEntity.SaleProcent,
            SalePrice= shoeEntity.SalePrice
        };
    }

    public List<ShoeEntity> ShoeList()
    {
        return new List<ShoeEntity>();
    }
}