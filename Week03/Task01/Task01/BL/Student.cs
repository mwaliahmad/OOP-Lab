using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.BL
{
    class Student
   {
        public Student()
        {
            Console.WriteLine("Default Constructor");
            name = "Wali";            
            matric = 1041F;
            inter = 1025F;
            ecat = 166F;
        }

        public Student(String name)
        {
            this.name = name;
        }

        public Student(String name,float matric ,float inter ,float ecat)
        {
            this.name = name;
            this.matric = matric;
            this.inter = inter;
            this.ecat = ecat; 
        }
        public string name;
        public float matric;
        public float inter;
        public float ecat;
        public float aggregate;
    }
}
