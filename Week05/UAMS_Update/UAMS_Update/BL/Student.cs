using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_Update.BL
{
    public class Student
    {
        public Student(string name, int age, int fscMarks, int ecatMarks)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            registeredDegree = null;
        }

        public string name;
        public int age;
        public int fscMarks;
        public int ecatMarks;
        public float merit;
        public Degree registeredDegree;
        public List<Degree> Preferences = new List<Degree>();
        public List<Subject> Subjects = new List<Subject>();
        public void AddPreference(Degree preference)
        {
            Preferences.Add(preference);
        }

        public void CalculateMerit()
        {
            float fscPercentage = (float)fscMarks / 1100 * 100;
            float ecatPercentage = (float)ecatMarks / 400 * 100;
            merit = 0.6F * fscPercentage + 0.4F * ecatPercentage;
        }

        public int GetCreditHours()
        {
            int ch = 0;
            foreach (var subject in Subjects)
            {
                ch += subject.creditHours;
            }

            return ch;
        }

        public float CalculateFees()
        {
            float fees = 0;
            foreach (var subject in Subjects)
            {
                fees += subject.fees * subject.creditHours;
            }
            return fees;
        }
    }
}
