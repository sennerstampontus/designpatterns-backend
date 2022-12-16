using designpatterns_api.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace designpatterns_api.Entities
{
    public class ShoeEntity
    {


        public ShoeEntity( string title, string description, decimal price, string category, int? rating, string imageUrl, string? heels, bool isOnSale, int saleProcent, decimal salePrice)
        {
            
            Title = title;
            Description = description;
            Price = price;
            Category= category;
            Rating = rating;
            ImageUrl = imageUrl;
            Heels = heels;
            IsOnSale = isOnSale;
            SaleProcent = saleProcent;
            SalePrice = salePrice;
        }

        public ShoeEntity()
        {

        }

        [Key]
        public string Id {get; set; } = Guid.NewGuid().ToString();
        [Required, Column(TypeName = "nvarchar(50)")]

        public string Title {get; set; } = string.Empty;
        [Required, Column(TypeName = "nvarchar(250)")]

        public string Description {get; set; } = null!;
        [Required, Column(TypeName = "money")]

        public decimal Price {get; set; }
        [Required, Column(TypeName = "nvarchar(50)")]

        public string Category { get; set; } = null!;
        public int? Rating {get; set; }


        [Required, Column(TypeName = "nvarchar(max)")]
        public string ImageUrl { get; set; } = null!;

        public string? Heels {get; set; }

        public bool IsOnSale { get; set; }
        public int SaleProcent { get; set; }
        [Column(TypeName = "money")]
        public decimal SalePrice { get; set; }

       
    }
}
