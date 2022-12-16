using designpatterns_api.Interfaces;


namespace SharedLib.Models
{
    public class SunglassesModel : BaseProduct, ISunglasses
    {
        public bool IsPolorized {get; set; }
        public bool HasStrenght {get; set; }

    }
}
