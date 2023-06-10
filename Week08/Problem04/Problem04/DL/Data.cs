using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04.BL;

namespace Problem04.DL
{
    public class Data
    {
        public static List<Shape> lst = new List<Shape>();

        public static void AddShape(Shape S)
        {
            lst.Add(S);
        }
    }
}
