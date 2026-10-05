using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfo
{
    internal class Student
    {
        private string fullName;
        private int facultyNumber;
        private string specialty;
        private string course;

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 3)
                    fullName = value;
                else
                    Console.WriteLine("Имената трябва да съдържат поне 3 символа!");
            }
        }

        public int FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (value > 0)
                    facultyNumber = value;
                else
                    Console.WriteLine("Факултетният номер не може да бъде отрицателно число или 0!");
            }
        }

        public string Specialty
        {
            get { return specialty; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 3)
                    specialty = value;
                else
                    Console.WriteLine("Специалността трябва да съдържа поне 3 символа!");
            }
        }

        public string Course
        {
            get { return course; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 3)
                    course = value;
                else
                    Console.WriteLine("Курсът трябва да съдържа поне 3 символа!");
            }
        }

        public Student()
        {
            FullName = "Иван Георгиев Петров";
            FacultyNumber = 12345;
            Specialty = "Софтуерно инженерство";
            Course = "Първи курс";
        }

        public Student(string fullName, int facultyNumber)
        {
            FullName = fullName;
            FacultyNumber = facultyNumber;
            Specialty = "Общ профил";
            Course = "Първи курс";
        }

        public Student(string fullName, int facultyNumber, string specialty, string course)
        {
            FullName = fullName;
            FacultyNumber = facultyNumber;
            Specialty = specialty;
            Course = course;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Имена: {FullName}");
            Console.WriteLine($"Факултетен номер: {FacultyNumber}");
            Console.WriteLine($"Специалност: {Specialty}");
            Console.WriteLine($"Курс: {Course}");
        }
    }
}
