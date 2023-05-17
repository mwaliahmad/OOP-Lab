using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem01.BL;

namespace Problem01.UI
{
    public class Display
    {
        public static int Menu()
        {
            Console.WriteLine("1.Add a Menu item");
            Console.WriteLine("2.View the Cheapest Item in the menu");
            Console.WriteLine("3.View the Drink’s Menu");
            Console.WriteLine("4.View the Food’s Menu");
            Console.WriteLine("5.Add Order");
            Console.WriteLine("6.Fulfill the Order");
            Console.WriteLine("7.View the Orders’s List");
            Console.WriteLine("8.Total Payable Amount");
            Console.WriteLine("9.Exit");
            Console.WriteLine();
            Console.Write("Enter Option: ");

            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
        public static void ShowHead()
        {
            Console.WriteLine("Name".PadRight(15) + "Type".PadRight(15) + "Price".PadRight(15));
            Console.WriteLine();
        }
        public static void ShowItem(Menu M)
        {
            Console.WriteLine(M.Name.PadRight(15) + M.Type.PadRight(15) + M.Price.ToString().PadRight(15));
        }
        public static void ShowPrice(float M)
        {
            Console.Write("Total Amount is: ");
            Console.WriteLine(M.ToString().PadRight(15));
        }
        public static void ShowItemList(List<Menu> M)
        {
            foreach (var items in M)
            {
                Console.WriteLine(items.Name.PadRight(15) + items.Type.PadRight(15) + items.Price.ToString().PadRight(15));
            }
        }
        public static void ShowOrdersList(List<string> M)
        {
            foreach (var items in M)
            {
                Console.WriteLine(items.PadRight(15));
            }
        }
        static public void Wrong()
        {
            Console.WriteLine("Wrong Input...");
        }
        static public void OrderAdded()
        {
            Console.WriteLine("Order Added");
        }
        public static void ClearBack()
        {
            Console.WriteLine();
            Console.WriteLine("Press Any Key for Back");
            Console.ReadKey();
            Console.Clear();
        }
        public static string OrderItem()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            return name;
        }
        public static Menu AddItem()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Price: ");
            float price = float.Parse(Console.ReadLine());
            Menu item = new Menu(name, type, price);
            return item;
        }
    }
}
