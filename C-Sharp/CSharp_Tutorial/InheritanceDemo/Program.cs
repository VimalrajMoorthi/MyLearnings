using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            // method of base class
            myRadio.SwitchOn();
            // method of Radio class
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Samsung");
            // method of base class
            myTV.SwitchOn();
            // method of TV class
            myTV.WatchTV();

            Console.ReadLine();
        }
    }
}
