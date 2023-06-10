using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.BL
{
    public class Mammal : Animal
    {
        public Mammal(string Name) : base(Name)
        {

        }
        public override string toString()
        {
            string line = "[Mammal"+ base.toString()+ "]";
            return line;
        }
        public override string Greets()
        {
            string line = "Undefined";
            return line;
        }
    }
}
