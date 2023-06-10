using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04.BL;

namespace Problem04.UI
{
    public class CircleInput
    {
        public static Circle Input()
        {
            Console.Write("Enter Radius: ");
            double r = double.Parse(Console.ReadLine());
            Circle C = new Circle(r, "Circle");
            return C;
        }
    }
}
