using designpatterns_api.Interfaces;


namespace designpatterns_api.Models;

public class ShoeModel : BaseProduct, IShoe
{
    private decimal salePrice;

    public string? Heels {get; set;}

    public string Category { get; private set; } = "Shoes";

    public decimal SalePrice { get { return salePrice; } private set { salePrice = CalculateSalePrice(Price, SaleProcent); } }


    public decimal CalculateSalePrice(decimal price, int procent)
    {
        var calcValue = price * procent / 100;
        return price - calcValue;
    }
}
