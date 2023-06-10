using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04.BL;

namespace Problem04.UI
{
    class RectInput
    {
        public static Rectangle Input()
        {
            Console.Write("Enter Length: ");
            double l = double.Parse(Console.ReadLine());
            Console.Write("Enter Width: ");
            double w = double.Parse(Console.ReadLine());
            Rectangle R = new Rectangle(l, w, "Rectangle");
            return R;
        }
    }
}
