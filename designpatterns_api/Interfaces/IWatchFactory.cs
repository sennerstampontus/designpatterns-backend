using designpatterns_api.Entities;

namespace designpatterns_api.Interfaces;

public interface IWatchFactory
{

    WatchEntity Create(string title, string description, decimal price, string category, bool isWaterproof, string watchType, string wristBand, int? rating, string imageUrl, bool isOnSale, int saleProcent, decimal salePrice);

    WatchEntity Watch(WatchEntity watchEntity);
    List<WatchEntity> WatchList();

}