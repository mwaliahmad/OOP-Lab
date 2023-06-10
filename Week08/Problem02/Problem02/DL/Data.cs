using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02.BL;

namespace Problem02.DL
{
    public class Data
    {
        public static List<Person> lst = new List<Person>();

        public static void AddPerson(Person P)
        {
            lst.Add(P);
        }
    }
}
