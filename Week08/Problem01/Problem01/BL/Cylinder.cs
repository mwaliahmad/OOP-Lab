using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    public class Cylinder : Circle
    {
        private double Height;
        public Cylinder()
        {

        }
        public Cylinder(double Radius) : base (Radius)
        {

        }
        public Cylinder(double Height,double Radius) :base (Radius)
        {
            this.Height = Height;
        }
        public Cylinder(double Height, double Radius, string Color) : base(Radius,Color)
        {
            this.Height = Height;
        }
        public double GetHeight()
        {
            return Height;
        }
        public void SetHeight(double Height)
        {
            this.Height = Height;
        }

        public double GetVolume()
        {
            return GetArea() * Height;
        }
    }
}
