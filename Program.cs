using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace SoftwareEngineering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SEStudent sEStudent1 = new SEStudent("Петр Петров", "C++");
            SEStudent sEStudent2 = new SEStudent("Ирина Рафатовна", "C#");
            SEStudent sEStudent3 = new SEStudent("Полина Воронова", "JavaScript");

            Department<SEStudent> department = new Department<SEStudent>
            {
                Title = "Прикладная информатика",
                Supervisor = "Дмитрий Иванов Дмитриевич"
            };

            department.EnrollStudent(sEStudent1);
            department.EnrollStudent(sEStudent2);
            department.EnrollStudent(sEStudent3);

            Console.WriteLine($"Отделение: {department.Title}");
            Console.WriteLine($"ФИО отвественного за отделение: {department.Supervisor}");

            department.ExpelStudent(sEStudent2);

            Console.WriteLine("Копия:");
            SEStudent[] seStudent = department.GetStudentsList();
            foreach ( SEStudent student in seStudent)
            {
                Console.WriteLine(student);
            }
        }
    }
}
