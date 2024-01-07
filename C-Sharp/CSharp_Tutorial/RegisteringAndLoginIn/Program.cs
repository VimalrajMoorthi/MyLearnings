// See https://aka.ms/new-console-template for more information

namespace RegisteringAndLoginIn
{

    class Program
    {

        static string? userName;
        static string? password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.ReadLine();
        }
        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed.");
            Console.WriteLine("----------------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (userName == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful.");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password, Restart Program");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username, Restart Program");
            }
        }
    }
}
