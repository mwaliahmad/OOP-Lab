using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange01.BL
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
        public int ElapseTime()
        {
            int second = (this.hr * 60 * 60) + (this.mint * 60) + this.sec;
            return second;
        }
        public int RemainingTime()
        {
            int secondCurrent = (this.hr * 60 * 60) + (this.mint * 60) + this.sec;
            return 86400 - secondCurrent;
        }
        public int Difference(ClockType C)
        {
            int second1 = (this.hr * 60 * 60) + (this.mint * 60) + this.sec;
            int second2 = (C.hr * 60 * 60) + (C.mint * 60) + C.sec;
            int difference = second1 - second2;
            if (difference < 0)
            {
                difference = difference * -1;
            }
            return difference;
        }
        public void formatter(int Time)
        {
            int hours;
            int minutes;
            int second;

            hours = Time / 3600;
            minutes = (Time / 60) % 60;
            second = Time - ((hours * 3600) + (minutes * 60));
            Console.WriteLine(hours + " : " + minutes + " : " + second);
        }
    }
}
