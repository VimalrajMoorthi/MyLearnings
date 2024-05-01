using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes___Basics;

namespace StacksDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Human Vimal = new Human("Vimalraj", "Moorthi", "Blue", 26);
            Vimal.IntroduceMySelf();

            Human Shree = new Human("Shree", "Lakshmi", "Brown");
            Shree.IntroduceMySelf();

            Human Rex = new Human("Antony", "Rex", 38);
            Rex.IntroduceMySelf();

            Human Elaya = new Human("Elaya", "Kumar");
            Elaya.IntroduceMySelf();

            Human Raju = new Human("Raju");
            Raju.IntroduceMySelf();

            Human basicHuman = new Human();
            basicHuman.IntroduceMySelf();

            Console.Read();
        }
    }
}
