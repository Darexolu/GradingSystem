namespace GradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Welcome To Student Grading System=====");
            Course course = new Course();
            Teacher teacher = new Teacher();


            Student student = new Student("Dare", 1234567);
            Student student2 = new Student("Segun", 1908456);
            Student student3 = new Student("Olu", 1476456);
            Student student4 = new Student("funmi", 1236543);
            Student student5 = new Student("Segun", 1942845);
            Student student6 = new Student("Olu", 187315);


            course.AddStudent(student);
            course.AddStudent(student2);
            course.AddStudent(student3);
            course.AddStudent(student4);
            course.AddStudent(student5);
            course.AddStudent(student6);



            Console.WriteLine("Enter 1. To Remove student 2. To Calculate Average: ");
            var result = int.Parse(Console.ReadLine());
            if (result == 1)
            {
                course.RemoveStudent(student);
            }
            else if (result == 2) { 
                
                course.AddStudent(student);
                course.AddStudent(student2);
                course.AddStudent(student3);
                course.AddStudent(student4);
                course.AddStudent(student5);
                course.AddStudent(student6);

                teacher.AddGrade(student, 56.9);
                teacher.AddGrade(student2, 76.6);
                teacher.AddGrade(student3, 75.3);
                teacher.AddGrade(student4, 68.3);
                teacher.AddGrade(student5, 92.3);
                teacher.AddGrade(student6, 88.3);

                course.CalculateAverageGrade();
            }
            else
            {
                Console.WriteLine("You have not entered a valid response!");
                return;
            }

          
        }
    }
}