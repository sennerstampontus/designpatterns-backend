using designpatterns_api.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace designpatterns_api.Entities
{
    public class WatchEntity
    {
        public WatchEntity(string id, string title, string description, decimal price, string category, int? rating, string imageUrl, bool isWaterproof, string watchType, string wristband, bool isOnSale, int saleProcent, int salePrice)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
            Category = category;
            Rating = rating;
            ImageUrl = imageUrl;
            IsWaterproof = isWaterproof;
            WatchType = watchType;
            Wristband = wristband;
            IsOnSale = isOnSale;
            SaleProcent = saleProcent;
            SalePrice = salePrice;
        }

        public WatchEntity()
        {

        }

        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required, Column(TypeName = "nvarchar(50)")]
        public string Title {get; set; } = string.Empty;
        [Required, Column(TypeName = "nvarchar(250)")]

        public string Description { get; set; } = string.Empty;
        [Required, Column(TypeName = "money")]

        public decimal Price { get; set; }
        [Required, Column(TypeName = "nvarchar(50)")]

        public string Category { get; set; } = string.Empty;

        public int? Rating { get; set; }

        [Required, Column(TypeName = "nvarchar(max)")]

        public string ImageUrl { get; set; } = string.Empty;
        [Required]

        public bool IsWaterproof { get; set; }
        [Required, Column(TypeName = "nvarchar(50)")]

        public string WatchType { get; set; } = string.Empty;
        [Required, Column(TypeName = "nvarchar(50)")]

        public string Wristband { get; set; } = string.Empty;
        [Required]


        public bool IsOnSale { get; set; }
        public int SaleProcent { get; set; }
        [Column(TypeName = "money")]

        public decimal SalePrice { get; set; }
    }
}
