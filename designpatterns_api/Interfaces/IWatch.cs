namespace designpatterns_api.Interfaces;


/// <summary>
/// This interface inherit it's fields from IProduct, due to LSP, I did this inheritance because the watch should be a product
/// with all what product has. With tweaks to fit a watch. That's where the IWatch comes in and puts other properties on the class that should inherit IWatch.
/// </summary>
public interface IWatch : IProduct
{
    public bool IsWaterproof { get; set; }
    public string WatchType { get; set; }
    public string Wristband { get; set; }

}
