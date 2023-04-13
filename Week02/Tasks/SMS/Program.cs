using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.BL;

namespace SMS
{
    class Program
    {
        /*class Students
        {
            public string name;
            public int roll_no;
            public float cgpa;
        }*/
        static void Main(string[] args)
        {
            // Task02();
            // Task03();
            // Task04();
            Task05();
        }
        /*static void Task02()
        {
            Students S1 = new Students();
            S1.name = "Wali";
            S1.roll_no = 65;
            S1.cgpa = 3.96F;

            Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2}", S1.name, S1.roll_no, S1.cgpa);
            Console.Read();
        }
        static void Task03()
        {
            Students S1 = new Students();
            S1.name = "Wali";
            S1.roll_no = 65;
            S1.cgpa = 3.96F;

            Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2}", S1.name, S1.roll_no, S1.cgpa);

            Students S2 = new Students();
            S2.name = "Ahmad";
            S2.roll_no = 56;
            S2.cgpa = 3.89F;

            Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2}", S2.name, S2.roll_no, S2.cgpa);
            Console.Read();
        }
        static void Task04()
        {
            Students S1 = new Students();

            Console.WriteLine("Enter Name:");
            S1.name = Console.ReadLine();

            Console.WriteLine("Enter Roll No:");
            S1.roll_no = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter CGPA:");
            S1.cgpa = float.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2}", S1.name, S1.roll_no, S1.cgpa);
            Console.Read();
        }*/
        static void Task05()
        {
            Student[] s = new Student[10];
            char option;
            int count = 0;
            do
            {
                option = Menu();
                if (option == '1')
                {
                    s[count] = AddStudent();
                    count++;
                }

                else if (option == '2')
                {
                    ViewStudent(s, count);
                }

                else if (option == '3')
                {
                    TopStudent(s, count);
                }

                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            while (option != '4');
            Console.WriteLine("Press any key for Back");
            Console.Read();
        }

        static char Menu()
        {
            char option;
            Console.Clear();
            Console.WriteLine("Press 1 for Add Student...");
            Console.WriteLine("Press 2 for View Students...");
            Console.WriteLine("Press 3 for Top three Student...");
            Console.WriteLine("Press 4 for Exit...");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static Student AddStudent()
        {
            Console.Clear();
            Student s1 = new Student();

            Console.Write("Enter Name: ");
            s1.name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            s1.rollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());

            Console.Write("Enter Hostel (y || n): ");
            s1.isHostelite = char.Parse(Console.ReadLine());

            Console.Write("Enter Department: ");
            s1.department = Console.ReadLine();

            return s1;
        }

        static void ViewStudent(Student[] s, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: {0} \n Roll Number: {1} \n CGPA: {2} \n Hostelite: {3} \n Department: {4} \n", s[i].name, s[i].rollNo, s[i].cgpa, s[i].isHostelite, s[i].department);
            }

            Console.WriteLine("Press Any Key For Back...");
            Console.ReadKey();
        }

        static void TopStudent(Student[] s, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No record Found");
            }
            else if (count == 1)
            {
                ViewStudent(s, 1);
            }

            else if (count == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    int index = Largest(s, i, count);
                    Student temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                ViewStudent(s, 2);
            }

            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int index = Largest(s, i, count);
                    Student temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                ViewStudent(s, 3);
            }
        }
        static int Largest(Student[] s, int start, int end)
        {
            int index = start;
            float large = s[start].cgpa;
            for (int i = start; i < end; i++)
            {
                if (s[i].cgpa > large)
                {
                    large = s[i].cgpa;
                    index = i;
                }
            }
            return index;

        }
    }
}
