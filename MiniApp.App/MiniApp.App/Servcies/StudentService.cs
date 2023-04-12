
using MiniApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MiniApp.App.Servcies
{
    internal class StudentService
    {
      private  Student[] Students = new Student[0];

        public  void ShowStudents()
        {
            if (Students.Length == 0)
            {
                Console.WriteLine("Not available Students");
            }

            foreach (Student student in Students)
            {
                student.GetFullInfo();
            }
        }

       public  void CreateStudent()
        {

            Student NewStudent = new Student();

            Console.WriteLine("add Name");
            NewStudent.Name = Console.ReadLine();
            Console.WriteLine("add Email");
            NewStudent.Email = Console.ReadLine();

            Array.Resize(ref Students, Students.Length + 1);

            Students[Students.Length - 1] = NewStudent;
        }

    }
}
