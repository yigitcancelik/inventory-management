using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class SellBO
    {
        public int SellID { set; get; }
        public string CustomerName { set; get; }
        public string ProductName { set; get; }
        public string TypeName { set; get; }
        public int ProductCount { set; get; }
        public decimal ProductPrice { set; get; }
        public DateTime SellDate { set; get; }
    }
}
