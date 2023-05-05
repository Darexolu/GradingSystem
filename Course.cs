using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GradingSystem
{
    public class Course
    {
       public IList<Student> students { get; set; }
        public Course()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            Console.WriteLine("Enter student ID: ");
            var remove = int.Parse(Console.ReadLine());
            foreach(var studen in students.ToList())
            {
                if(studen.ID == remove)
                {
                    students.Remove(studen);
                    Console.WriteLine("Student removed successfully");
                    return;
                }
                else 
                {
                    Console.WriteLine("Student ID not found!");
                    return;
                }
            }
            
        }
        public void CalculateAverageGrade()
        {
            double sum = 0;
            double average = 0;
            foreach(var student in students)
            {
                for (int i = 0; i < student.StudentGrades.Count; i++)
                {
                    sum += student.StudentGrades[i];
                }
            }
            average = sum / students.Count;

            Console.WriteLine($"Average score for students offering the course: {average:F}");

        }

    }
}
