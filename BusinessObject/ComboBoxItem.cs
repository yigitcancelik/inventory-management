using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

        public ComboBoxItem(string Text,string Value)
        {
            this.Text = Text;
            this.Value = Value;
        }
    }
}
