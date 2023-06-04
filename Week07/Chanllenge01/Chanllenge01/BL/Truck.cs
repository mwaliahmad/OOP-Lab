using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanllenge01.BL
{
    public class Truck
    {
        private Ladder L;
        private Pipe P;
        private Employee E;
        public Truck(Ladder L, Pipe P, Employee E)
        {
            this.L = L;
            this.P = P;
            this.E = E;
        }
    }
}
