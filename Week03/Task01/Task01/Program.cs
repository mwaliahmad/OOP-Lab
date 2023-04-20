using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.BL;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task01();
            // Task02();
            // Task03(); 
            // Task03a();
            // Task03b();
            // Task04();
            // Task04a();
            // Task04b();
             Task05();
            Console.ReadKey();
        }

        static void Task01()
        {
            Student s = new Student();
            Console.WriteLine(s.name);
            Console.WriteLine(s.matric);
            Console.WriteLine(s.inter);
            Console.WriteLine(s.ecat);
            Console.WriteLine(s.aggregate);
        }
        static void Task02()
        {
            Student s = new Student();
        }
        static void Task03()
        {
            Student s = new Student();
            Console.WriteLine(s.name);
        }
        static void Task03a()
        {
            Student s = new Student();
            Console.WriteLine(s.name);
            Console.WriteLine(s.matric);
            Console.WriteLine(s.inter);
            Console.WriteLine(s.ecat);
            Console.WriteLine(s.aggregate);
        }
        static void Task03b()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matric);
            Console.WriteLine(s1.inter);
            Console.WriteLine(s1.ecat);
            Console.WriteLine(s1.aggregate);

            Student s2 = new Student();
            Console.WriteLine(s2.name);
            Console.WriteLine(s2.matric);
            Console.WriteLine(s2.inter);
            Console.WriteLine(s2.ecat);
            Console.WriteLine(s2.aggregate);
        }
        static void Task04()
        {
            Student s1 = new Student("WALI");
            Console.WriteLine(s1.name);

            Student s2 = new Student("Ahmad");
            Console.WriteLine(s2.name);
        }
        static void Task04a()
        {
            Student s1 = new Student("ALI", 1025F, 1041F, 661F);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matric);
            Console.WriteLine(s1.inter);
            Console.WriteLine(s1.ecat);
        }
        static void Task04b()
        {
            Student s1 = new Student("ALI", 1025F, 1041F, 661F);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matric);
            Console.WriteLine(s1.inter);
            Console.WriteLine(s1.ecat);

            Student s2 = new Student("AHI", 1205F, 1401F, 616F);
            Console.WriteLine(s2.name);
            Console.WriteLine(s2.matric);
            Console.WriteLine(s2.inter);
            Console.WriteLine(s2.ecat);
        }
        static void Task05()
        {
            List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

        }

    }
}
