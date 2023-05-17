using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    public class Menu
    {
        public Menu(string Name,string Type, float Price)
        {
            this.Name = Name;
            this.Type = Type;
            this.Price = Price;
        }
        public string Name;
        public string Type;
        public float Price;

    }
}
