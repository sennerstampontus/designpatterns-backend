namespace designpatterns_api.Interfaces
{

    public interface IProduct
    {

       
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int? Rating { get; set; }
        public string ImageUrl { get; set; }
        public bool IsOnSale { get; set; }
        public int SaleProcent { get; set; }
        public decimal SalePrice { get; set; }
    }
}
