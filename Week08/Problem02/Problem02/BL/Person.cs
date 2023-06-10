using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.BL
{
    public class Person
    {
        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        protected string Name;
        protected string Address;
        public string GetName()
        {
            return Name;
        }
        public string GetAddress()
        {
            return Address;
        }
        public void SetAddress(string Address)
        {
            this.Address = Address;
        }
        public virtual string toString()
        {
            return "Undefined";
        }
    }
}
