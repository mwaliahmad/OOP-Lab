using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03.BL;

namespace Problem03.DL
{
    public class Data
    {
        public static List<Animal> lst = new List<Animal>();
        public static void AddAnimal(Animal A)
        {
            lst.Add(A);
        }
    }
}
