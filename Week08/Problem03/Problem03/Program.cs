using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03.BL;
using Problem03.DL;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat C1 = new Cat("Billi");
            Cat C2 = new Cat("Billlllllli");
            Dog D1 = new Dog("Doggy");
            Dog D2 = new Dog("Dogggggggyyyy");

            Data.AddAnimal(C1);
            Data.AddAnimal(C2);
            Data.AddAnimal(D1);
            Data.AddAnimal(D2);

            foreach(var A in Data.lst)
            {
                Console.WriteLine(A.toString());
                Console.WriteLine(A.Greets());
            }

            Console.ReadKey();
        }
    }
}
