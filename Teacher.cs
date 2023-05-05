namespace GradingSystem
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Course> courses { get; set; }
        public Teacher()
        {
           
            courses = new List<Course>();

        }
        public void AddGrade(Student student, double grade)
        {
            var Grades = student.StudentGrades;
            Grades.Add(grade);
            foreach (var item in courses)
            {
                if (student != item.students)
                {
                    Console.WriteLine("Student have not enrolled!");
                }
              
            }
        }
    }
}
