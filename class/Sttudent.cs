using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool isGraduated;

        public Student(string name, string surname, string group, byte point, bool isgraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            isGraduated = isgraduated;
        }

        public void AllValues()
        {
            Console.Write(Name + " " + Surname + " " + Group + " " + Point + " ");

            if (isGraduated==true)
            {
                Console.WriteLine("Bu telebe mezun olub");
            }
            else
            {
                Console.WriteLine("Bu telebe mezun olmayib");
            }
        }

        public void Exam()
        {
            if (Point>80)
            {
                Console.WriteLine("Ikinci imtahana gire biler");
            }
            else
            {
                Console.WriteLine("Ikinci imtahana gire bilmez");
            }
        }
    
    }
}
