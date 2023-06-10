using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.BL
{
    public class Animal
    {
        protected string Name;
        public Animal(string Name)
        {
            this.Name = Name;
        }
        public virtual string toString()
        {
            string line = "[Animal[Name= " + Name + " ]";
            return line;
        }
        public virtual string Greets()
        {
            string line = "Undefined";
            return line;
        }
    }
}
