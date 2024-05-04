using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    // Subclass Car that extends Vehicle
    class Car : Vehicle
    {
        // Simple constructor
        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}
