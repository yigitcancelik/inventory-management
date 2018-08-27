using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing; 

namespace BusinessObject
{
    public class PreferencesBO
    {
        public static int Limit { set; get; }
        public static string EmptyColor { set; get; }
        public static string NormalColor { set; get; }
        public static string LowColor { set; get; }
        public static Color Empty { set; get; }
        public static Color Normal { set; get; }
        public static Color Low { set; get; }
    }
}
