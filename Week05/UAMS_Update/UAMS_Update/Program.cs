using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Update.BL;

namespace UAMS_Update
{
    class Program
    {
        static List<Student> Students = new List<Student>();
        static List<Degree> Degrees = new List<Degree>();
        static void Main(string[] args)
        {
            int option;
            while (true)
            {
                Console.Clear();
                PrintMainMenu();
                option = GetValidNumber(8, "Option: ");
                if (option == 1)
                {
                    if (Degrees.Count != 0)
                    {
                        Students.Add(AddStudent());
                    }
                    else
                    {
                        Console.WriteLine("First Add Degree Program Before Adding Students");
                        DisplayContinueDialog();
                    }
                }
                else if (option == 2)
                {
                    Degrees.Add(AddDegree());
                }
                else if (option == 3)
                {
                    GenerateMeritList();
                }
                else if (option == 4)
                {
                    ViewRegisteredStudents();
                }
                else if (option == 5)
                {
                    ViewSpecificProgram();
                }
                else if (option == 6)
                {
                    RegisterSubjects();
                }
                else if (option == 7)
                {
                    CalculateFees();
                }
                else
                {
                    break;
                }
            }
        }

        static void PrintMainMenu()
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a Specific Program");
            Console.WriteLine("6. Register Subjects for a Specific Student");
            Console.WriteLine("7. Calculate Fees for all Registered Students");
            Console.WriteLine("8. Exit");
            Console.WriteLine();
        }

        static int GetValidNumber(int range, string text)
        {
            int y = Console.CursorTop;
            string option;
            do
            {
                ClearLine(y);
                Console.SetCursorPosition(0, y);
                Console.Write(text);
                option = Console.ReadLine();

            } while (!ValidateOption(option, range));

            return int.Parse(option);
        }

        static bool ValidateOption(string option, int range)
        {
            bool isValid = false;
            int number;
            if (int.TryParse(option, out number))
            {
                if (number <= range && number > 0)
                {
                    isValid = true;
                }
            }

            return isValid;
        }

        static void ClearLine(int y)
        {
            Console.SetCursorPosition(0, y);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(" ");
            }
        }

        static void DisplayContinueDialog()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static Student AddStudent()
        {
            Console.Clear();
            string name;
            int age, fscMarks, ecatMarks;
            Console.Clear();
            Console.Write("Student Name: ");
            name = Console.ReadLine();
            Console.Write("Student Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Student FSC Marks: ");
            fscMarks = int.Parse(Console.ReadLine());
            Console.Write("Student Ecat Marks: ");
            ecatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("---= Offered Degree Programs =---");
            Student student = new Student(name, age, fscMarks, ecatMarks);
            foreach (var degree in Degrees)
            {
                Console.WriteLine(degree.name);
            }
            int n = GetValidNumber(Degrees.Count, "Number of Prefrences To Enter: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Preference {0}: ", i + 1);
                Degree preference = GetPreference(Console.ReadLine());
                if (preference == null)
                {
                    Console.WriteLine("Invaid Preference");
                }
                else
                {
                    Console.WriteLine("Preference Added Successfully");
                    student.AddPreference(preference);
                }
            }
            DisplayContinueDialog();
            return student;
        }

        static Degree GetPreference(string preference)
        {
            Degree degree = null;
            foreach (var currentDegree in Degrees)
            {
                if (currentDegree.name == preference)
                {
                    degree = currentDegree;
                    break;
                }
            }

            return degree;
        }

        static Degree AddDegree()
        {
            Console.Clear();
            string name;
            int duration, seats;
            Console.Write("Degree Name: ");
            name = Console.ReadLine();
            Console.Write("Degree Duration: ");
            duration = int.Parse(Console.ReadLine());
            Console.Write("Degree Total Seats: ");
            seats = int.Parse(Console.ReadLine());

            Degree degree = new Degree(name, duration, seats);
            Console.WriteLine("---= Add Subjects Of Max 20 CH =---");
            string confrimation;
            do
            {
                Console.Write("Subject Code: ");
                int code = int.Parse(Console.ReadLine());
                Console.Write("Subject Type: ");
                string type = Console.ReadLine();
                Console.Write("Subject Credit Hours: ");
                int creditHours = int.Parse(Console.ReadLine());
                Console.Write("Subject Fees: ");
                int fees = int.Parse(Console.ReadLine());
                if (degree.GetCreditHours() + creditHours > 20)
                {
                    Console.WriteLine("Failed! Credit Hours Cannot Exceed 20");
                }
                else
                {
                    degree.AddSubject(new Subject(code, type, creditHours, fees));
                }
                Console.Write("Add Another Subject (Y / N): ");
                confrimation = Console.ReadLine();
            } while (confrimation == "Y");
            DisplayContinueDialog();
            return degree;
        }

        static void GenerateMeritList()
        {
            Console.Clear();
            foreach (var student in Students)
            {
                student.CalculateMerit();
            }

            Students.Sort((a, b) => a.merit.CompareTo(b.merit));
            Students.Reverse();

            foreach (var student in Students)
            {
                foreach (var preference in student.Preferences)
                {
                    if (preference.availableSeats > 0)
                    {
                        student.registeredDegree = preference;
                        preference.availableSeats--;
                        break;
                    }
                }
                if (student.registeredDegree == null)
                {
                    Console.WriteLine("{0} Did Not Got Admission", student.name);
                }
                else
                {
                    Console.WriteLine("{0} Got Admission in {1}", student.name, student.registeredDegree.name);
                }
            }
            DisplayContinueDialog();
        }

        static void ViewRegisteredStudents()
        {
            Console.Clear();
            Console.WriteLine("Name\tFsc\teCAT\tAge\n");
            foreach (var student in Students)
            {
                if (student.registeredDegree != null)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", student.name, student.fscMarks, student.ecatMarks, student.age);
                }
            }
            DisplayContinueDialog();
        }

        static void ViewSpecificProgram()
        {
            Console.Clear();
            Console.Write("Degree Program: ");
            string degree = Console.ReadLine();
            if (Degrees.Find(d => d.name == degree) != null)
            {
                foreach (var student in Students)
                {
                    if (student.registeredDegree != null)
                    {
                        if (student.registeredDegree.name == degree)
                        {
                            Console.WriteLine(student.name);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Degree Program Does Not Exists");
            }
            DisplayContinueDialog();
        }

        static void RegisterSubjects()
        {
            Console.Clear();
            string confrimation;
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Student student = Students.Find(s => s.name == name);
            if (student != null)
            {
                Console.WriteLine("---= Offered Subjects =---");
                foreach (var subject in student.registeredDegree.Subjects)
                {
                    Console.WriteLine(subject.type);
                }
                do
                {
                    Console.Write("Subject Name: ");
                    string subject = Console.ReadLine();
                    Subject sub = student.registeredDegree.Subjects.Find(s => s.type == subject);
                    if (sub == null)
                    {
                        Console.WriteLine("Subject Does Not Exist");
                    }
                    else
                    {
                        if (student.GetCreditHours() + sub.GetCreditHours() > 9)
                        {
                            Console.WriteLine("Failed! Credit Hours Cannot Exceed 9");
                        }
                        else
                        {
                            student.Subjects.Add(sub);
                        }
                    }
                    Console.Write("Add Another Subject (Y / N): ");
                    confrimation = Console.ReadLine();
                } while (confrimation == "Y");
            }
            else
            {
                Console.WriteLine("Student Does Not Exists!!!");
            }
            DisplayContinueDialog();
        }

        static void CalculateFees()
        {
            Console.Clear();
            Console.WriteLine("Name\tFees");
            foreach (var student in Students)
            {
                if (student.registeredDegree != null)
                {
                    Console.WriteLine("{0}\t{1}", student.name, student.CalculateFees());
                }
            }
            DisplayContinueDialog();
        }
    }
}

