using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.BL
{
    public class Student : Person
    {
        private string Program;
        private int Year;
        private double Fee;
        public Student(string Program, int Year,double Fee, string Name, string Address) :base(Name , Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }
        public string GetProgram()
        {
            return Program;
        }
        public void SetProgram(string Program)
        {
            this.Program = Program;
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetYear(int Year)
        {
            this.Year = Year;
        }
        public double GetFee()
        {
            return Fee;
        }
        public void SetFee(double Fee)
        {
            this.Fee = Fee;
        }
        public override string toString()
        {
            string line = "Person[Name= " + GetName() + " Address= " + GetAddress() + " Program= " + GetProgram() + " Year= " + GetYear().ToString() + " Fee= " + GetFee().ToString() +"]"; 
            return line;
        }
    }
}
