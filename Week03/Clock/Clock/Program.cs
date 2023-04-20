using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clock.BL;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockType Empty = new ClockType();
            Console.Write("Empty Time: ");
            Empty.PrintTime();
            Console.WriteLine();

            ClockType Hour = new ClockType(8);
            Console.Write("Hours Time: ");
            Hour.PrintTime();
            Console.WriteLine();

            ClockType Mint = new ClockType(8,10);
            Console.Write("Minutes Time: ");
            Mint.PrintTime();
            Console.WriteLine();

            ClockType FullTime = new ClockType(8, 10,10);
            Console.Write("Full Time: ");
            FullTime.PrintTime();
            Console.WriteLine();

            FullTime.incrementSec();
            Console.Write("Full Time(Sec Increment): ");
            FullTime.PrintTime();
            Console.WriteLine();

            FullTime.incrementMint();
            Console.Write("Full Time(Mint Increment): ");
            FullTime.PrintTime();
            Console.WriteLine();

            FullTime.incrementHr();
            Console.Write("Full Time(Hr Increment): ");
            FullTime.PrintTime();
            Console.WriteLine();

            bool flag = FullTime.isEqual(9,11,11);
            Console.WriteLine("Flag: " + flag);
            Console.WriteLine();

            ClockType temp = new ClockType(9, 10, 11);
            flag = FullTime.isEqual(temp);
            Console.WriteLine("Object Flag: " + flag);
            Console.WriteLine();

            Console.ReadKey();
        }

        
    }
}
