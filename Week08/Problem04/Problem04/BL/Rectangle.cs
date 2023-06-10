using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04.BL
{
    public class Rectangle : Shape
    {
        private double Length;
        private double Width;

        public Rectangle(double Length, double Width, string Type) : base(Type)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public double GetLength()
        {
            return Length;
        }
        public void SetLength(double Length)
        {
            this.Length = Length;
        }
        public double GetWidth()
        {
            return Width;
        }
        public void SetWidth(double Width)
        {
            this.Width = Width;
        }
        public double GetArea()
        {
            return GetLength() * GetWidth();
        }
        public override string toString()
        {
            return "The Shape is " + Type + " and its Area is " + GetArea().ToString();
        }
    }
}
