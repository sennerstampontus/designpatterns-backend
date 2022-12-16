using designpatterns_api.Entities;

namespace SharedLib.Factories
{
    /// <summary>
    /// WatchFactory is used to create an instance of Watch model when creating a watch to database. This so avoid to create an instance in the controller. Part of "Dependency Inversion Principle"
    /// 
    /// It could seem to be a repeated action to have two, almost identical factories. But I rather have SRP in this case and split the factories into two/three. And have it a little bit cleaner in the controller 
    /// 
    /// </summary>
    public static class WatchFactory
    {

        public static WatchEntity Create(string title, string description, decimal price, string category, bool isWaterproof, string watchType, string wristBand, int? rating, string imageUrl, bool isOnSale, int saleProcent, decimal salePrice)
        {

            return new WatchEntity() { Title = title, Description = description, Price = price, Category = category, WatchType = watchType, Wristband = wristBand, IsWaterproof = isWaterproof, Rating = rating, ImageUrl = imageUrl, IsOnSale = isOnSale, SaleProcent = saleProcent, SalePrice = salePrice };

        }
    }
}