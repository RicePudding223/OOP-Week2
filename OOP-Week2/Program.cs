using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Alice", "Object-Oriented Programming", 70);
            student.DisplayInfo();

            Console.Write("Press any key to exit... ");
            Console.ReadLine();
        }
    }

    public class Student
    {
        private string _name;
        private string _module;
        private int _mark;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _name = "NoName";
                }
                else
                {
                    _name = value;
                }
            }
        }

        public string Module
        {
            get { return _module; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Module cannot be empty");
                }
                else
                {
                    _module = value;
                }
            }
        }

        public int Mark
        {
            get { return _mark; }
            set
            {
                if (value < 0 || value > 100)
                {
                    _mark = 0;
                }
                else
                {
                    _mark = value;
                }
            }
        }
        public Student(string _name, string _module, int _mark)
        {
            this.Name = _name;
            this.Module = _module;
            this.Mark = _mark;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"The student: {this.Name} attended the module {this.Module} and was marked with {this.Mark}");
            Console.WriteLine($"The student: {this.Name} was graded with: {ComputeGradeCategory()}");
        }

        public string ComputeGradeCategory()
        {
            if (this.Mark > 0 && this.Mark < 50)
            {
                return "Fail";
            }
            else if (this.Mark >= 50 && this.Mark < 60)
            {
                return "Pass";
            }
            else if (this.Mark >= 60 && this.Mark < 70)
            {
                return "Merit";
            }
            else if (this.Mark >= 70 && this.Mark <= 100)
            {
                return "Distinction";
            }
            else
            {
                return "Missing mark";
            }
        }
    }
}
