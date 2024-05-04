using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    // Subclass chair that extends Furniture
    class Chair : Furniture
    {
        // Simple Constructor
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
