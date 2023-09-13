using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                //Create and save new "Student"
                Console.WriteLine("Enter student name.[FirstName] [LastName]: ");
                var studentName = Console.ReadLine();

                var student = new Student { StudentName = studentName };
                db.Students.Add(student);
                db.SaveChanges();

                //Displays all Students
                var query = from b in db.Students
                            orderby b.StudentName
                            select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }
            }


        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
    
    }


    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
