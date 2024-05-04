using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    // Base class for Furnitures
    class Furniture
    {
        // color of the furniture
        public string Color { get; set; }
        // material of the furniture
        public string Material { get; set; }

        // Default constructor
        public Furniture()
        {
            Color = "White";
            Material = "Wood";
        }

        // Simple constructor
        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
