using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    public class Shop
    {
        public Shop(string Name)
        {
            this.Name = Name;
            Items = new List<Menu>();
            Orders = new List<string>();
        }
        public string Name;
        public List<Menu> Items;
        public List<string> Orders;

        public void AddItem(Menu M)
        {
            Items.Add(M);
        }
        public Menu Cheapest()
        {
            List<Menu> Sort = new List<Menu>();
            Sort = Items.OrderBy(o => o.Price).ToList();
            return Sort[0];
        }
        public void OrderItem(string name)
        {
            Orders.Add(name);
        }
        public void FulfillItem(int idx)
        {
            Orders.RemoveAt(idx);
        }
        public List<Menu> Category(string category)
        {
            List<Menu> drinks = new List<Menu>();
            foreach (var M in Items)
            {
                if (M.Type == category)
                {
                    drinks.Add(M);
                }
            }
            return drinks;
        }

        public float amount()
        {
            float total = 0;
            foreach(var M in Orders)
            {
                total += GetPrice(M);
            }
            return total;
        }
        public float GetPrice(string name)
        {
            return Items.Find(items => items.Name == name).Price;
        }
    }
}
