using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem01.BL;
using Problem01.UI;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt;
            Shop S = new Shop("Wali");
            do
            {
                opt = Display.Menu();
                Console.Clear();
                if (opt == 1)
                {
                    Menu M = Display.AddItem();
                    S.AddItem(M);
                    Display.ClearBack();
                }
                else if (opt == 2)
                {
                    Menu M = S.Cheapest();
                    Display.ShowHead();
                    Display.ShowItem(M);
                    Display.ClearBack();
                }
                else if (opt == 3)
                {
                    Display.ShowHead();
                    List<Menu> drinks;
                    drinks = S.Category("Drink");
                    Display.ShowItemList(drinks);
                    Display.ClearBack();

                }
                else if (opt == 4)
                {
                    Display.ShowHead();
                    List<Menu> food;
                    food = S.Category("Food");
                    Display.ShowItemList(food);
                    Display.ClearBack();
                }
                else if (opt == 5)
                {
                    string name = Display.OrderItem();
                    Menu flag = S.Items.Find(item => item.Name == name);
                    if (flag != null)
                    {
                        S.OrderItem(name);
                        Display.OrderAdded();
                    }
                    else
                    {
                        Display.Wrong();
                    }
                    Display.ClearBack();
                }
                else if (opt == 6)
                {
                    int x = 0;
                    S.FulfillItem(x);
                    x++;
                    Display.ClearBack();
                }
                else if (opt == 7)
                {
                    Display.ShowOrdersList(S.Orders);
                    Display.ClearBack();
                }
                else if (opt == 8)
                {
                    float price = S.amount();
                    Display.ShowPrice(price);
                    Display.ClearBack();
                }
                else if (opt > 9)
                {
                    Display.Wrong();
                }
            }
            while (opt != 9);
            Display.ClearBack();
        }
    }
}
