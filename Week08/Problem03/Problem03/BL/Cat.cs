using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.BL
{
    public class Cat : Mammal
    {
        public Cat(string Name) : base(Name)
        {

        }
        public override string toString()
        {
            string line = "Cat" +base.toString() + "]";
            return line;
        }
        public override string Greets()
        {
            string line = "Meow";
            return line;
        }
    }
}
