using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public IList<double> StudentGrades { get; set; }

        public Student(string name, int id)
        {
            Name = name;
            ID = id;
            StudentGrades = new List<double>();
        }
       


        public override string ToString(){
            return $"Name: {Name}\nID: {ID}";
        }

    }
}
