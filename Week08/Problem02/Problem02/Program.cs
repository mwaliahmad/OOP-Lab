using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Problem02.BL;
using Problem02.DL;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student2 = new Student("BSCE", 2021, 4560, "AS", "House 39");
            Student student1 = new Student("BSCS", 2022, 4500, "AR", "House 34");
            Staff staff1 = new Staff("UET", 45000, "Anas", "H 55");
            Staff staff2 = new Staff("UMT", 45060, "Ans", "H 50");


            Data.AddPerson(student1);
            Data.AddPerson(student2);
            Data.AddPerson(staff1); 
            Data.AddPerson(staff1);

            foreach(var A in Data.lst)
            {
                Console.WriteLine(A.toString());
            }
            Console.ReadKey();
        }
    }
}
