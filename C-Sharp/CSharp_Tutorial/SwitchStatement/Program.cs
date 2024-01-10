// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int age = 22;

        switch (age)
        {
            case 15:
                Console.WriteLine("Too young to party in the club!");
                break;
            case 25:
                Console.WriteLine("Good to go!");
                break;
            default:
                Console.WriteLine("how old are you then?");
                break;
        }
        if (age == 15)
        {
            Console.WriteLine("Too young to party in the club!");
        }
        else if (age == 25)
        {
            Console.WriteLine("Good to go!");
        }
        else
        {
            Console.WriteLine("how old are you then?");
        }

        string userName = "groot";

        switch (userName)
        {
            case "Vimal":
                Console.WriteLine("Hi" + userName);
                break;
            case "groot":
                Console.WriteLine("I am groot!");
                break;
            default:
                Console.WriteLine("unknown person");
                break;
        }

        Console.Read();
    }
}