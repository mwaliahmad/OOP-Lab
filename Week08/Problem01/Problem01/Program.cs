using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem01.BL;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cylinder> list = new List<Cylinder>();
            Cylinder C1 = new Cylinder();
            Cylinder C3 = new Cylinder(5.1F, 1.3F);
            Cylinder C2 = new Cylinder(2.1F, 5.3F, "Black");
            list.Add(C1);
            list.Add(C2);
            list.Add(C3);

            C1.SetColor("Black");
            C1.SetRadius(3.6F);
            C1.SetHeight(2.5F);

            C2.SetColor("Black");

            foreach(var C in list)
            {

            double A = C.GetVolume();
            Console.WriteLine(A);
            }
            Console.ReadKey();
        }
    }
}
