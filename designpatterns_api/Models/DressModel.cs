using designpatterns_api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Models
{
    internal class DressModel : BaseProduct, IDress
    {
        public string DressLength { get; set; } = null!;
        public string Sleeves { get; set; } = null!;

    }
}
