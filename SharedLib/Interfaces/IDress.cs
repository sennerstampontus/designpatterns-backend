namespace designpatterns_api.Interfaces
{
    public interface IDress : IProduct
    {
        public string DressLength { get; set; }
        public string Sleeves { get; set; }
    }
}
