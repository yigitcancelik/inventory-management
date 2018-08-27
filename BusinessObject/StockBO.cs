using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class StockBO
    {
        public int StockID { set; get; }
        public string StockName { set; get; }
        public string StockType { set; get; }
        public int StockCount { set; get; }
        public DateTime StockDate { set; get; }
    }
}
