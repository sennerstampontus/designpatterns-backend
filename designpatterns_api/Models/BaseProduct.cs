using designpatterns_api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Models
{

    /// <summary>
    /// This is the base properties of a product. And will be inherited to suitable classes. To follow LSP
    /// it should be a fitting class like, watch, shoe, glasses etc. All of them has the same base properties.
    /// It also follows an inteface to be more strict. This class is also contributing in DRY, I don't have to repeat
    /// these properties on classes that inherit this base class.
    /// </summary>
    public abstract class BaseProduct : IProduct
    {
        public string Title {get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;
        public int? Rating {get; set; }
        public string ImageUrl { get; set; } = null!;
        public bool IsOnSale { get; set; }
        public int SaleProcent { get; set; }
        public decimal SalePrice { get; set;}
    }
}
