using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.BL
{
    public class Dog : Mammal
    {
        public Dog(string Name) : base(Name)
        {

        }
        public override string toString()
        {
            string line = "Dog[" + base.toString() + "]";
            return line;
        }
        public override string Greets()
        {
            string line = "Woof";
            return line;
        }
    }
}
