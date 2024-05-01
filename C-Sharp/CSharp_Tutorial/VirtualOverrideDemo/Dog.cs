using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Dog:Animal
    {
        public bool IsHappy { get; set; }

        // simple constructor where we pass the name and age to our base constructor
        public Dog(string name, int age):base(name, age)
        {
            // all dogs are happy ;)
            IsHappy = true;
        }

        // simple override of the virtual method Eat
        public override void Eat()
        {
            // to call the Eat method from our base class we use the keyword "base"
            base.Eat();
        }

        // override of the virtual method MakeSound
        public override void MakeSound()
        {
            // since every animal will make a totally different sound
            // each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuuf!.");
        }

        // override of the virtual method Play
        public override void Play()
        {
            // check if the do is happy if yes call Play method from the base
            // class
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
