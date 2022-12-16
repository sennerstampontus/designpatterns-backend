﻿using designpatterns_api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Models
{
    public class WatchModel : BaseProduct, IWatch
    {

        private decimal salePrice;

        public bool IsWaterproof {get; set; }
        public string WatchType { get; set; } = null!;  
        public string Wristband { get; set; } = null!;
        public string Category { get; private set; } = "Watches";

        public decimal SalePrice { get { return salePrice; } private set { salePrice = CalculateSalePrice(Price, SaleProcent); } }


        public decimal CalculateSalePrice(decimal price, int procent)
        {
            var calcValue = price * procent / 100;
            return price - calcValue;
        }
    }
}
