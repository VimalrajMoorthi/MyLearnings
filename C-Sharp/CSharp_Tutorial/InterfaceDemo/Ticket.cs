using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Ticket : IEquatable<Ticket>
    {
        // Property to store the duration of the ticket in hours

        public int DurationHours { get; set; }

        // Simple constructor
        public Ticket(int durationHours)
        {
            this.DurationHours = durationHours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurationHours == other.DurationHours;
        }
    }
}
