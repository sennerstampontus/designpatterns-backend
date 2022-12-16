using SharedLib.Models;
using System.Drawing;

namespace designpatterns_api.Interfaces
{

    /// <summary>
    /// This interface inherit it's fields from IProduct, due to LSP, I did this inheritance because the shoe should be a product
    /// with all what product has. With tweaks to fit a shoe.
    /// </summary>

    public interface IShoe : IProduct
    {

        public string? Heels { get; set; }
    }
}
