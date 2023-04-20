using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Challange02.BL;

namespace Challange02
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt;
            List<Store> S = new List<Store>();
            do
            {
                opt = Menu();
                if (opt == 1)
                {
                    AddProduct(S);
                }
                else if (opt == 2)
                {
                    ViewProduct(S);
                }
                else if (opt == 3)
                {
                    PrintHighPrice(S);
                }
                else if (opt == 4)
                {
                    PrintTax(S);
                }
                else if (opt == 5)
                {
                    OrderToBe(S);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Thread.Sleep(300);
                }
            }
            while (opt != 6);
            Console.WriteLine();
            Console.WriteLine("Press Any Key for Exit");
            Console.ReadKey();
        }
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1. ADD PRODUCT");
            Console.WriteLine("2. VIEW ALL PRODUCTS");
            Console.WriteLine("3. VIEW HIGHEST PRICE PRODUCT");
            Console.WriteLine("4. VIEW ALL SALE TAX");
            Console.WriteLine("5. VIEW PRODUCT TO BE ORDERED");
            Console.WriteLine("6. EXIT");

            Console.WriteLine();

            Console.Write("Select Your Option: ");

            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
        static void AddProduct(List<Store> S)
        {
            Console.Clear();
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Console.Write("Price: ");
            float price = float.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine());

            Console.Write("Low Stock: ");
            int lowStock = int.Parse(Console.ReadLine());

            Store S1 = new Store(name, category, price, stock, lowStock);
            S.Add(S1);

            Console.WriteLine();

            Console.WriteLine("Press Any Key for Back");
            Console.ReadKey();
        }
        static void ViewProduct(List<Store> S)
        {
            Console.Clear();
            foreach (var i in S)
            {
                Console.WriteLine("Name : {0}", i.name);
                Console.WriteLine("Category : {0}", i.category);
                Console.WriteLine("Price : {0}", i.price);
                Console.WriteLine("Stock : {0}", i.stock);
                Console.WriteLine("Low Stock : {0}", i.stockLow);
                Console.WriteLine();

            }
            Console.WriteLine("Press Any Key for Back");
            Console.ReadKey();
        }
        static void PrintHighPrice(List<Store> S)
        {
            Console.Clear();

            string Hname = "";
            string Hcategory = "";
            float Hprice = -1f;

            foreach (var i in S)
            {
                if (Hprice <= i.price)
                {
                    Hprice = i.price;
                    Hname = i.name;
                    Hcategory = i.category;
                }
            }
            Console.WriteLine("Name \t\t Category \t\t Price");
            Console.WriteLine("{0} \t\t {1} \t\t {2}", Hname, Hcategory, Hprice);

            Console.WriteLine();

            Console.WriteLine("Press Any Key for Back");
            Console.ReadKey();
        }
        static void PrintTax(List<Store> S)
        {
            Console.Clear();
            Console.WriteLine("Name".PadRight(15) + "Category".PadRight(15) + "Price".PadRight(15) + "Tax".PadRight(15));
            Console.WriteLine();

            foreach (var i in S)
            {
                float tax = i.TaxCalculate();
                Console.WriteLine(i.name.PadRight(15) + i.category.PadRight(15) + i.price.ToString().PadRight(15) + tax.ToString().PadRight(15));
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key for Back");
            Console.ReadKey();
        }
        static void OrderToBe(List<Store> S)
        {
            Console.Clear();
            bool flag = true;
            foreach (var i in S)
            {
                if (i.stock < i.stockLow)
                {
                    Console.Write("Products Having Low Stock: ");
                    Console.WriteLine("Name: " + i.name + "--- Stock: " + i.stock);
                    flag = false;
                }

            }
            if (flag == true)
            {
                Console.WriteLine("None of the Products having Low Stock");
            }

            Console.WriteLine();

            Console.WriteLine("Press Any Key for Back");
            Console.ReadKey();
        }
    }
}
