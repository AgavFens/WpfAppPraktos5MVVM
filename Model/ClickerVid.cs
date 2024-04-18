using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPraktos5MVVM
{
    public class ClickerVid
    {
        public ClickerVid(string name, string color) 
        {
            Name = name;
            Color = color;
        }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
