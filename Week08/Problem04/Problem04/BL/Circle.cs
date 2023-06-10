using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04.BL
{
    public class Circle : Shape
    {
        public Circle(double Radius, string Type) : base(Type)
        {
            this.Radius = Radius;
        }
        private double Radius;

        public double GetRadius()
        {
            return Radius;
        }
        public void SetRadius(double Radius)
        {
            this.Radius = Radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(GetRadius(), 2);
        }
        public override string toString()
        {
            return "The Shape is " + Type + " and its Area is " + GetArea().ToString();
        }
    }
}
