using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.BL;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task01();
            // Task02();
            // Task03();
        }

        static void Task01()
        {
            Student S = new Student("Wali", 65, 3.97F, 1041, 1025, 266, "Lahore", false, true);
            S.MeritCalculator();
            Console.WriteLine("Student Merit {0}", S.merit);

            bool flap = S.CheckScholarship();
            Console.WriteLine(flap);
            Console.ReadKey();
        }
        static void Task02()
        {
            List<string> Chapters = new List<string>
            {
                "0. Iron Man",
                "1. Iron Man 2",
                "2. Iron Man 3",
                "3. Iron Man 4"
            };

            Book B = new Book("Anas", 40, Chapters, 5, 25.2F);

            string chapter = B.GetChapter(2);
            Console.WriteLine(chapter);

            int bookmark = B.GetBookmark();
            Console.WriteLine(bookmark);

            B.SetBookmark(4);
            int bookmark2 = B.GetBookmark();
            Console.WriteLine(bookmark2);

            float price = B.GetPrice();
            Console.WriteLine(price);

            B.SetPrice(44.2F);
            float price2 = B.GetPrice();
            Console.WriteLine(price2);

            Console.ReadKey();
        }
        static void Task03()
        {

            Product P1 = new Product("Anas", "Human", 150.0F);
            Product P2 = new Product("Sabur", "man", 100.0F);
            Product P3 = new Product("AR", "woman", 250.0F);
            Product P4 = new Product("Wali", "man", 120.0F);

            Customer C = new Customer("Wali Ahmad" , "Contact" , "03370433034");

            C.AddProduct(P1);
            C.AddProduct(P4);
            C.AddProduct(P2);

            List <Product> Ps =  C.GetProducts();
            float totalTax = C.GetAllTax();

            Console.WriteLine(totalTax);
            Console.ReadKey();
        }
    }
}
