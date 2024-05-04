using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            Name = "Vimalraj";
            FirstName = "Moorthi";
            Salary = 50000;

        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("I am working");
        }

        public void Break()
        {
            Console.WriteLine("I'm having a break");
        }
    }
}
