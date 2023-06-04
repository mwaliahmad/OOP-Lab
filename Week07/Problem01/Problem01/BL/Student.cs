using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    class Student
    {
        protected string Name;
        protected int Session;
        protected bool IsDayScholar;
        protected int Ecat;
        protected int Inter;
        public Student(string Name,int Session,bool IsDayScholar,int Ecat,int Inter)
        {
            this.Name = Name;
            this.Session = Session;
            this.IsDayScholar = IsDayScholar;
            this.Ecat = Ecat;
            this.Inter = Inter;
        }
        public float GetMerit()
        {
            float fee = 0;
            return fee;
        }
    }
}
