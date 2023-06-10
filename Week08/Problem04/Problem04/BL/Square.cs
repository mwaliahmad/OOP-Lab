using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04.BL
{
    public class Sqaure : Shape
    {
        public Sqaure(double Side, string Type) : base(Type)
        {
            this.Side = Side;
        }

        private double Side;

        public double GetSide()
        {
            return Side;
        }
        public void SetSide(double Side)
        {
            this.Side = Side;
        }

        public double GetArea()
        {
            return Math.Pow(GetSide(), 2);
        }
        public override string toString()
        {
            return "The Shape is " + Type + " and its Area is " + GetArea().ToString();
        }
    }
}
