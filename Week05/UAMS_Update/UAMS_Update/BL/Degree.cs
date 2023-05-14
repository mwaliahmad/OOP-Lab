using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_Update.BL
{
    public class Degree
    {
        public Degree(string name, int duration, int seats)
        {
            this.name = name;
            this.duration = duration;
            totalSeats = seats;
            availableSeats = seats;
        }
        public string name;
        public int duration;
        public int totalSeats;
        public int availableSeats;
        public List<Subject> Subjects = new List<Subject>();

        public int GetCreditHours()
        {
            int ch = 0;
            foreach (var subject in Subjects)
            {
                ch += subject.creditHours;
            }

            return ch;
        }

        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }
    }
}
