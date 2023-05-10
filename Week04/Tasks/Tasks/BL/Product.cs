using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.BL
{
    public class Product
    {
        public Product(string name, string category, float price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }

        public string name;
        public string category;
        public float price;

        public float TaxCalculate()
        {
            float tax = (price * 10) / 100;
            return tax;
        }
    }

}
