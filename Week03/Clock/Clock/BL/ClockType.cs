using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.BL
{
    class ClockType
    {
        public ClockType()
        {
            hr = 0;
            mint = 0;
            sec = 0;
        }
        public ClockType(int hr)
        {
            this.hr = hr;
        }
        public ClockType(int hr, int mint)
        {
            this.hr = hr;
            this.mint = mint;
        }
        public ClockType(int hr, int mint, int sec)
        {
            this.hr = hr;
            this.mint = mint;
            this.sec = sec;
        }

        public int hr;
        public int mint;
        public int sec;
        public void incrementSec()
        {
            sec++;
        }
        public void incrementMint()
        {
            mint++;
        }
        public void incrementHr()
        {
            hr++;
        }
        public void PrintTime()
        {
            Console.WriteLine(hr + " : " + mint + " : " + sec);
        }

        public bool isEqual(int hr, int mint, int sec)
        {
            if (this.hr == hr && this.mint == mint && this.sec == sec)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(ClockType temp)
        {
            if (this.hr == temp.hr && this.mint == temp.mint && this.sec == temp.sec)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
