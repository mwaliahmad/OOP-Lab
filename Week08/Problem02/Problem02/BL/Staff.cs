using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.BL
{
    public class Staff : Person
    {
        private string School;
        private double Pay;
        public Staff(string School, double Pay, string Name, string Address) : base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        public string GetSchool()
        {
            return School;
        }
        public void SetSchool(string School)
        {
            this.School = School;
        }
        public double GetPay()
        {
            return Pay;
        }
        public void SetPay(double Pay)
        {
            this.Pay = Pay;
        }
        public override string toString()
        {
            string line = "Person[Name= " + GetName() + " Address= " + GetAddress() + " School= " + GetSchool() + " Pay= " + GetPay().ToString() +"]";
            return line;
        }
    }
}
