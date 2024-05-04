using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    class Program
    {
        // Create a main class with Main method, then a base class Employee with the properties Name,
        // FirstName, Salary and the methods Work() and Pause().
        // Create a deriving class Boss with the property CompanyCar and the method Lead().
        // Create another deriving class of Employee - Trainee with the properties WorkinHours
        // and SchoolHours and a method Learn();
        // override the methods Work() of the Trainee class so that it indicates
        // the working hours of the trainee.
        // Don't forget to create the Constructors.
        // Create an object of each of the three classes (with arbitary values)
        // and call the methods, Lead() of Boss and Work() of Trainess.
        // Just print out the respective text, what the respective employees do.
        static void Main(string[] args)
        {
            Employee vimal = new Employee("Vimalraj", "Moorthi", 40000);
            vimal.Work();
            vimal.Break();

            Boss elaya = new Boss("Lamborgini", "Elaya", "Kumar", 100000);
            elaya.Lead();

            Trainee michelle = new Trainee(32, 8, "Michelle", "Gartner", 10000);
            michelle.Learn();
            michelle.Work();

            Console.ReadKey();
        }
    }
}
