using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.BL
{
    public class Student
    {
        public Student(string name, int rollNumber, float cgpa, int matric, int inter, int ecat, string city, bool isHostelite, bool scholarshipStatus)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.cgpa = cgpa;
            this.matric = matric;
            this.inter = inter;
            this.ecat = ecat;
            this.city = city;
            this.isHostelite = isHostelite;
            this.scholarshipStatus = scholarshipStatus;
        }

        public string name;
        public int rollNumber;
        public float cgpa;
        public int matric;
        public int inter;
        public int ecat;
        public float merit;
        public string city;
        public bool isHostelite;
        public bool scholarshipStatus;

        public void MeritCalculator()
        {
            float interPercent = (inter / 1100F) * 100F;
            float ecatPercent = (ecat / 400F) * 100F;
            merit = (interPercent * 0.6F) + (ecatPercent * 0.4F);
        }
        public bool CheckScholarship()
        {
            bool flag;
            if (merit > 80)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
    }
}
