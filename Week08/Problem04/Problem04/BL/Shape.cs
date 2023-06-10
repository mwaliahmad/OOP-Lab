using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04.BL
{
    public class Shape
    {
        protected string Type;
        public Shape(string Type)
        {
            this.Type = Type;
        }
        public string getType()
        {
            return Type;
        }
        public virtual string toString()
        {
            return "Undefined";
        }
    }
}
