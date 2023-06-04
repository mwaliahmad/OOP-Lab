using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanllenge01.BL
{
    public class Pipe
    {
        private string Rubber;
        private string Shape;
        private int Diameter;
        private int FlowRate;
        public Pipe(string Rubber, string Shape,int Diameter, int FlowRate)
        {
            this.Rubber = Rubber;
            this.Shape = Shape;
            this.Diameter = Diameter;
            this.FlowRate = FlowRate;
        }
    }
}
