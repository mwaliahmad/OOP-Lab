using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challanges.BL;
using System.IO;
namespace Challanges
{
    class Program
    {
        static void Main(string[] args)
        {
            C2();
        }

        static void C2()
        {
            List<Credentials> C = new List<Credentials>();
            string path = "D:\\GitHub\\OOP Lab\\Week02\\Challanges\\Challanges\\file.txt";

            int option;
            do
            {
                ReadData(path, C);
                Console.Clear();
                option = Menu();

                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string p = Console.ReadLine();
                    SignIn(n, p, C);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter New Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter New Password: ");
                    string p = Console.ReadLine();
                    SignUp(path, n, p);
                }
            }
            while (option < 3);
            Console.Read();
        }
        static void ReadData(string path, List<Credentials> users)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader File = new StreamReader(path);
                string line;
                while ((line = File.ReadLine()) != null)
                {
                    Credentials User = new Credentials();

                    User.username = ParseData(line, 1);
                    User.password = ParseData(line, 2);
                    users.Add(User);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                File.Close();
            }
            else
            {
                Console.WriteLine("File Doesn't Exist");
            }
        }
        static string ParseData(string line, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < line.Length; x++)
            {
                if (line[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + line[x];
                }
            }
            return item;
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("Enter Option");
            option = int.Parse((Console.ReadLine()));
            return option;
        }
        static void SignIn(string n, string p, List<Credentials> users)
        {
            bool flag = false;
            for (int x = 0; x < users.Count; x++)
            {
                if (n == users[x].username && p == users[x].password)
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
        static void SignUp(string path, string n, string p)
        {
            StreamWriter File = new StreamWriter(path, true);
            File.WriteLine(n + "," + p);
            File.Flush();
            File.Close();
        }

        static void C1()
        {
            Console.Clear();
            Product[] P = new Product[10];
            int count = 0;
            int option = 0;
            do
            {
                option = PMenu();
                if (option == 1)
                {
                    P[count] = AddProduct();
                    count++;
                }
                else if (option == 2)
                {
                    ViewProduct(P, count);
                }
                else if (option == 3)
                {
                    Worth(P, count);
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            while (option != 4);
            Console.WriteLine("Press Any key For Exit");
            Console.ReadKey();

        }
        static int PMenu()
        {
            int opt;
            Console.Clear();
            Console.WriteLine("Press 1 for Add Product");
            Console.WriteLine("Press 2 for View Product");
            Console.WriteLine("Press 3 for Total Worth");
            Console.WriteLine("Press 4 for Exit");

            opt = int.Parse(Console.ReadLine());
            return opt;

        }
        static Product AddProduct()
        {
            Console.Clear();
            Product P1 = new Product();

            Console.Write("Enter ID: ");
            P1.ID = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            P1.name = Console.ReadLine();

            Console.Write("Enter Price: ");
            P1.price = float.Parse(Console.ReadLine());

            Console.Write("Enter Category: ");
            P1.category = Console.ReadLine();

            Console.Write("Enter Brand Name: ");
            P1.brand = Console.ReadLine();

            Console.Write("Enter Country: ");
            P1.country = Console.ReadLine();

            return P1;
        }
        static void ViewProduct(Product[] P, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("ID: {0} \n Name: {1} \n Price: {2} \n Category: {3} \n Brand Name: {4} \n Country: {5} \n", P[i].ID, P[i].name, P[i].price, P[i].category, P[i].brand, P[i].country);
            }

            Console.WriteLine("Press Any Key For Back...");
            Console.ReadKey();
        }

        static void Worth(Product[] P, int count)
        {
            Console.Clear();
            float total = 0;
            for (int i = 0; i < count; i++)
            {
                total = total + P[i].price;
            }

            Console.WriteLine("Total Worth is: {0} \n", total);
            Console.WriteLine("Press Any Key For Back...");
            Console.ReadKey();
        }
    }
}
