using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04.BL;

namespace Problem04.UI
{
    public class SquareInput
    {
        public static Sqaure Input()
        {
            Console.Write("Enter Side: ");
            double s = double.Parse(Console.ReadLine());
            Sqaure S = new Sqaure(s, "Square");
            return S;
        }
    }
}
