// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // declaring multiple variable at once
        int num3, num4, num5;
        // declaring a variable
        int num1;
        // assigning a value to a variable
        num1 = 13;

        // declaring and initializing a variable in one go
        int num2 = 23;
        num2 = 100;

        // using concatination
        Console.WriteLine("num1 is " + num1);
        int sum = num1 + num2;
        Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

        double d1 = 3.1415;
        double d2 = 5.1;
        double dDiv = d1 / d2;
        Console.WriteLine("d1/d2 is " + dDiv);

        float f1 = 3.1415f;
        float f2 = 5.1f;
        float fDiv = f1 / f2;
        Console.WriteLine("f1/f2 is " + fDiv);

        double diDiv = d1 / num1;
        Console.WriteLine("d1/num1 " + diDiv);

        string myName = "Vimal";
        // Strig Concatenation
        string message = "My name is " + myName;
        string messageCaps = message.ToUpper();
        Console.WriteLine(messageCaps);
        string messageLower = message.ToLower();
        Console.WriteLine(messageLower);

        Console.Write("Enter a string and press enter : ");
        string readInput = Console.ReadLine();
        Console.WriteLine("You have entered {0}", readInput);

        Console.Write("Enter any key and press enter : ");
        int asciiValue = Console.Read();
        // String formatting
        Console.WriteLine("ASCII value is {0}:", asciiValue);
        //Console.ReadKey();

        string stringForFloat = "0.85"; // datatype should be float
        string stringForInt = "12345"; // datatype should be int

        Console.WriteLine(stringForFloat.Length);

        float myFloat = float.Parse(stringForFloat);
        int myInt = Int32.Parse(stringForInt);
        // String Interpolation
        Console.WriteLine($"My float value is: {myFloat.ToString()}, My int value is {myInt}");

        #region DesitionMaking

        Console.Write("What's the temperature like?:");
        string temperature = Console.ReadLine();
        int numTemp;
        int number;
        if (temperature != null && temperature != string.Empty)
        {
            //numTemp = int.Parse(temperature);
            if (int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number. 0 set as temperature");
            }
        }
        else
        {
            numTemp = 0;
        }

        if (numTemp < 20)
        {
            Console.WriteLine("Take the coat");
        }
        else if (numTemp == 20)
        {
            Console.WriteLine("Pants and Pull Over should be fine");
        }
        else if(numTemp > 20)
        {
            Console.WriteLine("Shorts are enough today");
        }
   
        #endregion

        Console.Read();
    }
}