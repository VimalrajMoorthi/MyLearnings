using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    // Parent - Base
    class ElectricalDevice
    {
        // boolean to determine the state of the Radio
        public bool IsOn { get; set; }
        // string for the brand name of the radio
        public string Brand { get; set; }

        // Contructor
        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = IsOn;
            Brand = brand;
        }

        // switch on the TV
        public void SwitchOn()
        {
            IsOn = true;
        }

        // switch off the TV
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
