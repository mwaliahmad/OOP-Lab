using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task01();
            // Task02();
            // Task2a();
            // Task2b();
            // Task2c();
            // Task2d();
            // Task2e();
            // Task2f();
            // Task2g();
            // Task03();
            // Task04();
            // Task05();
            // Task06();
            // Task07();
            // Task08();
            // Task09();
            // Task10();
            // Task11();
            // Task12();
            // Task13();
            Task14();
        }
        static void Task01()
        {
            Console.Write("Hello World!!");
            Console.Write("Hello World!!");
            Console.Read();
        }
        static void Task02()
        {
            Console.WriteLine("Hello World!!");
            Console.WriteLine("Hello World!!");
            Console.Read();
        }
        static void Task2a()
        {
            int number = 9;
            Console.WriteLine("Number is: ");
            Console.WriteLine(number);
            Console.Read();
        }
        static void Task2b()
        {
            string line = "I am Programmer";
            Console.WriteLine("String is: ");
            Console.WriteLine(line);
            Console.Read();
        }
        static void Task2c()
        {
            char character = 'A';
            Console.WriteLine("Character is: ");
            Console.WriteLine(character);
            Console.Read();
        }
        static void Task2d()
        {
            float number = 9.2F;
            Console.WriteLine("Number is: ");
            Console.WriteLine(number);
            Console.Read();
        }
        static void Task2e()
        {
            string line;
            line = Console.ReadLine();
            Console.WriteLine("Your Input is:");
            Console.WriteLine(line);
            Console.Read();
        }
        static void Task2f()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("You Input a number");
            Console.WriteLine("the Number is: ");
            Console.WriteLine(number);
            Console.Read();
        }
        static void Task2g()
        {
            float number;
            number = float.Parse(Console.ReadLine());
            Console.WriteLine("You Input a number");
            Console.WriteLine("the Number is: ");
            Console.WriteLine(number);
            Console.Read();
        }
        static void Task03()
        {
            int length;
            int area;
            Console.WriteLine("Enter Length: ");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Area is: ");
            area = length * length;
            Console.WriteLine(area);
            Console.Read();
        }
        static void Task04()
        {
            float number;
            Console.WriteLine("Enter Marks");
            number = float.Parse(Console.ReadLine());
            if (number > 50)
            {
                Console.WriteLine("You are Passed");
            }
            else
            {
                Console.WriteLine("You are FAIL");
            }
            Console.Read();
        }
        static void Task05()
        {
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Welcome Wali");
            }
            Console.Read();
        }
        static void Task06()
        {
            int num;
            int sum = 0;
            Console.WriteLine("Enter Number: ");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                sum = sum + num;
                Console.WriteLine("Enter Number: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum is " + sum);
            Console.Read();
        }
        static void Task07()
        {
            int num = 0;
            int sum = 0;
            do
            {
                sum = sum + num;
                Console.WriteLine("Enter Number: ");
                num = int.Parse(Console.ReadLine());
            }
            while (num != -1);
            Console.WriteLine("Sum is " + sum);
            Console.Read();
        }
        static void Task08()
        {
            int[] set = new int[5];
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Enter Number " + (x + 1) + ": ");
                set[x] = int.Parse(Console.ReadLine());
            }
            int larger = -1;
            for (int x = 0; x < 5; x++)
            {
                if (set[x] > larger)
                {
                    larger = set[x];
                }
            }
            Console.WriteLine("larger Number is: " + larger);
            Console.Read();
        }
        static void Task09()
        {
            int Age;
            float ToyPrice, MachinePrice;
            Console.WriteLine("Enter Your Age: ");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price of Toy: ");
            ToyPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price of Machine: ");
            MachinePrice = float.Parse(Console.ReadLine());
            float Result = CalculateMoney(Age, ToyPrice);
            float Remaining = Result - MachinePrice;
            if (Remaining >= 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(Remaining);
            }
            else if (Remaining < 0)
            {
                Console.WriteLine("No");
                Console.WriteLine(-1 * Remaining);
            }
            Console.Read();
        }
        static float CalculateMoney(int age, float ToyPrice)
        {
            int gift = 10;
            int totalgift = 0;
            int toys = 0;

            for (int presentage = 1; presentage <= age; presentage = presentage + 1)
            {
                if (presentage % 2 == 0)
                {
                    totalgift = totalgift + (gift - 1);
                    gift = gift + 10;
                }
                else
                {
                    toys = toys + 1;
                }
            }

            float totalToycost = toys * ToyPrice;
            float totalcost = totalToycost + totalgift;

            return totalcost;
        }
        static void Task10()
        {
            int num1;
            int num2;
            int result;
            Console.Write("Enter Number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            num2 = int.Parse(Console.ReadLine());
            result = add(num1, num2);
            Console.Write("Sum is: " + result);
            Console.Read();
        }
        static int add(int n1, int n2)
        {
            return n1 + n2;
        }
        static void Task11()
        {
            string path = "D:\\GitHub\\OOP Lab\\Week01\\Tasks\\Tasks\\data.txt";
            if (File.Exists(path))
            {
                StreamReader File = new StreamReader(path);
                string line;
                while ((line = File.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                File.Close();
            }
            else
            {
                Console.WriteLine("File Doesn't Exist");
            }
            Console.Read();
        }
        static void Task12()
        {
            string path = "D:\\GitHub\\OOP Lab\\Week01\\Tasks\\Tasks\\data.txt";
            StreamWriter File = new StreamWriter(path, true);
            File.WriteLine("Hello");
            File.Flush();
            File.Close();
        }
        static void Task13()
        {
            string path = "D:\\GitHub\\OOP Lab\\Week01\\Tasks\\Tasks\\file.txt";
            string[] names = new string[5];
            string[] passwords = new string[5];
            int option;

            do
            {
                ReadData(path, names, passwords);
                Console.Clear();
                option = Menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string p = Console.ReadLine();
                    SignIn(n, p, names, passwords);
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
        static void ReadData(string path, string[] names, string[] passwords)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader File = new StreamReader(path);
                string line;
                while ((line = File.ReadLine()) != null)
                {
                    names[x] = ParseData(line, 1);
                    passwords[x] = ParseData(line, 2);
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
        static void SignIn(string n, string p, string[] names, string[] passwords)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if (n == names[x] && p == passwords[x])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
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
        static void Task14()
        {
            string path = "D:\\GitHub\\OOP Lab\\Week01\\Tasks\\Tasks\\pizza.txt";
            string name, order, set;
            int orderinInt;
            
            Console.WriteLine("Enter Number of Orders");
            int InputOrder = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price of Order");
            int PriceOrder = int.Parse(Console.ReadLine());

            int count =0;
            if (File.Exists(path))
            {
                StreamReader File = new StreamReader(path);
                string line;
                while ((line = File.ReadLine()) != null)
                {
                    name = PizzaParseData(line, 1);
                    order = PizzaParseData(line, 2);
                    set = PizzaParseData(line, 3);
                    orderinInt = int.Parse(order);
                    int[] setinInt = new int[orderinInt];

                    for (int x = 0; x < orderinInt; x++)
                    {
                        setinInt[x] = int.Parse(PizzaParseDataSet(set, x));
                        Console.WriteLine(setinInt[x]);
                        if (setinInt[x] >= PriceOrder)
                        {
                            count++;
                        }
                    }

                    /*for (int x = 0; x < orderinInt; x++)
                    {
                    }*/

                    if (count == InputOrder)
                    {
                        Console.WriteLine(name);
                    }
                    count = 0;
                }
                File.Close();
            }
            else
            {
                Console.WriteLine("File Doesn't Exist");
            }
            Console.Read();

        }
        static string PizzaParseData(string line, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < line.Length; x++)
            {
                if (line[x] == ' ')
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
        static string PizzaParseDataSet(string line, int field)
        {
            int comma = 0;
            string item = "";
            for (int x = 1; x < line.Length-1; x++)
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
    }
}

