using System.Text;

namespace Class
{
internal class Program
    {
    static void Main(string[] args)
        {
            Student student = new Student("Lutfu", "Mammadov", "P327", 79, true);
            Student student1 = new Student("Orxan", "Eliyev", "G543", 89, false);

            student.AllValues();
            student.Exam();
            student1.AllValues();
            student1.Exam();
        }
    }
}
