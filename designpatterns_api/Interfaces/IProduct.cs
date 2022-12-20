namespace designpatterns_api.Interfaces
{

    // Having a IProduct with the basic props of a product, we contain
    // ourselfs to the principle of ISP. We have no dependency problem.
    // If there is a product, they have ALL of these props, the is NO unused attribute.

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
