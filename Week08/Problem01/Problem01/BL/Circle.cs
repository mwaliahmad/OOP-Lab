using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    public class Circle
    {
        private double Radius;
        private string Color;

        public Circle()
        {

        }
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public Circle(double Radius, string Color)
        {
            this.Radius = Radius;
            this.Color = Color;
        }
        public double GetRadius()
        {
            return Radius;
        }
        public void SetRadius(double Radius)
        {
            this.Radius=Radius;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public double GetArea()
        {
            return Math.PI * (Radius * Radius);
        }
        public string toString()
        {
            string line = "Circle [Radius= {0} , Color= {1}]", Radius, Color;
            return line;
        }
    }
}
