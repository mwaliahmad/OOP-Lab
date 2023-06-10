using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04.BL;
using Problem04.DL;
using Problem04.UI;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R1 = RectInput.Input();
            Circle C1 = CircleInput.Input();
            Sqaure S1 = SquareInput.Input();
            Rectangle R2 = RectInput.Input();
            Circle C2 = CircleInput.Input();

            Data.AddShape(R1);
            Data.AddShape(C1);
            Data.AddShape(S1);
            Data.AddShape(R2);
            Data.AddShape(C2);
            Data.AddShape(R1);

            foreach (var A in Data.lst)
            {
                Console.WriteLine(A.toString());
            }
            Console.ReadKey();
        }
    }
}
