using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class TypeBO
    {
        public int TypeID { set; get; }
        public string TypeName { set; get; }
        public int TypeCount { set; get; }
        public decimal TypePrice { set; get; }
        public int ProductID { set; get; }
    }
}
