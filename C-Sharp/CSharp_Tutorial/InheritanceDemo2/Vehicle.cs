using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    // Base class for vehicles
    class Vehicle
    {
        // Speed of the vehicle
        public float Speed { get; set; }
        // Color of the vehicle
        public string Color { get; set; }

        // default constructor
        public Vehicle()
        {
            Speed = 120f;
            Color = "White";
        }

        // Simple constructor
        public Vehicle(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}
