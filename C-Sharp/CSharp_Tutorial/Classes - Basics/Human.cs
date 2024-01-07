using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string eyeColor = string.Empty;
        private int age = 0;

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. object created");
        }

        // parameterized constructors
        public Human(string firstName)
        {
            this.firstName = firstName;
        }
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }   
        public void IntroduceMySelf()
        {
            if (age != 0 && lastName != string.Empty && eyeColor != string.Empty && firstName != string.Empty)
                Console.WriteLine("Hi, I'm {0} {1} and {2} year old. My eye color is {3}", firstName, lastName, age, eyeColor);
            else if (age != 0 && lastName != string.Empty && firstName != string.Empty)
                Console.WriteLine("Hi, I'm {0} {1} and {2} year old.", firstName, lastName, age);
            else if (eyeColor != string.Empty && lastName != string.Empty && firstName != string.Empty)
                Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}", firstName, lastName, eyeColor);
            else if (lastName != string.Empty && firstName != string.Empty)
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            else if (firstName != string.Empty)
                Console.WriteLine("Hi, I'm {0}.", firstName);
        }
    }
}
