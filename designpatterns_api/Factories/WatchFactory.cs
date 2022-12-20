using designpatterns_api.Entities;
using designpatterns_api.Interfaces;

namespace designpatterns_api.Factories;


/// <summary>
/// WatchFactory is used to create an instance of Watch model when creating a watch to database. This so avoid to create an instance in the controller. Part of "Dependency Inversion Principle"
/// 
/// It could seem to be a repeated action to have two, almost identical factories. But I rather have SRP in this case and split the factories into two/three. And have it a little bit cleaner in the controller 
/// 
/// </summary>
public class WatchFactory : IWatchFactory
{
    public WatchEntity Create(string title, string description, decimal price, string category, bool isWaterproof, string watchType, string wristBand, int? rating, string imageUrl, bool isOnSale, int saleProcent, decimal salePrice)
    {

        return new WatchEntity() { Title = title, Description = description, Price = price, Category = category, WatchType = watchType, Wristband = wristBand, IsWaterproof = isWaterproof, Rating = rating, ImageUrl = imageUrl, IsOnSale = isOnSale, SaleProcent = saleProcent, SalePrice = salePrice };
    }

    public WatchEntity Watch(WatchEntity watchEntity)
    {
        return new WatchEntity()
        {
            Id= watchEntity.Id,
            Title = watchEntity.Title,
            Description = watchEntity.Description,
            Price = watchEntity.Price,
            Category = watchEntity.Category,
            WatchType = watchEntity.WatchType,
            Wristband = watchEntity.Wristband,
            IsWaterproof = watchEntity.IsWaterproof,
            Rating = watchEntity.Rating,
            ImageUrl = watchEntity.ImageUrl,
            IsOnSale = watchEntity.IsOnSale,
            SaleProcent = watchEntity.SaleProcent,
            SalePrice = watchEntity.SalePrice
        };
    }

    public List<WatchEntity> WatchList()
    {
        return new List<WatchEntity>();
    }
}