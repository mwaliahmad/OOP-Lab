using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanllenge01.BL
{
    public class Ladder
    {
        private int Lenght;
        private string Color;
        public Ladder(int Length, string Color)
        {
            this.Lenght = Length;
            this.Color = Color;
        }
        public int Length   // property
        {
            get { return Lenght; }   // get method
            set { Lenght = value; }  // set method
        }
    }
}
