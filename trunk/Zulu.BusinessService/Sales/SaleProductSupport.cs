using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zulu.BusinessService.Sales
{
    public class SaleProductSupport
    {
        public string ProductBarcode { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        
        public int TotalCost 
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }
    }
}
