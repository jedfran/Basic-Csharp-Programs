using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of 10 Employees (2 of them has to be named Joe)
            List<Employee> store = new List<Employee>()
            {
                new Employee() {ID = 1, FirstName = "Joe", LastName = "Shcultz"},
                new Employee() {ID = 2, FirstName = "Joe", LastName = "Brown"},
                new Employee() {ID = 3, FirstName = "Kevin", LastName = "Lee"},
                new Employee() {ID = 4, FirstName = "Daisy", LastName = "Gel"},
                new Employee() {ID = 5, FirstName = "Rose", LastName = "Peters"},
                new Employee() {ID = 6, FirstName = "Mike", LastName = "Francisco"},
                new Employee() {ID = 7, FirstName = "Thomas", LastName = "Lou"},
                new Employee() {ID = 8, FirstName = "James", LastName = "Taylor"},
                new Employee() {ID = 9, FirstName = "Sophia", LastName = "Gagnon"},
                new Employee() {ID = 10, FirstName = "Cindy", LastName = "Kang"}
            };

            //New List for just Joes'
            List<Employee> joe = new List<Employee>();
            //For each loop
            foreach (Employee employee in store)
            {
                if (employee.FirstName == "Joe")
                {
                    //adding employee if their name is "Joe"
                    joe.Add(employee);
                }
            }
            //Instead of foreach loop use lambda expression
            List<Employee> lambdaJoe = store.Where(x => x.FirstName == "Joe").ToList();


            //List of Employees with ID number greater than 5 using Lambda Expression
            List<Employee> lambdaID = store.Where(x => x.ID > 5).ToList();
            Console.ReadLine();
           
        }
    }
}
