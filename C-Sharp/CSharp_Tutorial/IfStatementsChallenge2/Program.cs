// See https://aka.ms/new-console-template for more information

class Program
{
    static int highScore = 390;
    static string highScorePlayer = "Vimal";

    static void Main(string[] args)
    {
        CheckHighScore(250, "Maria");
        CheckHighScore(400, "Michael");
        CheckHighScore(380, "Vimalraj");

        Console.Read();

    }
    
    static void CheckHighScore(int score, string playerName)
    {
        if (score > highScore)
        {
            highScore = score;
            highScorePlayer = playerName;

            // short if
            highScore = score > highScore ? score : highScore;
            int temperature;
            string stateofMatter;
            temperature = 100;
            stateofMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine(stateofMatter);

            Console.WriteLine("The new high score is : " + highScore);
            Console.WriteLine("It is now held by : " + highScorePlayer);
        }
        else
        {
            Console.WriteLine("The old high score could not be broken. It is still "
                + highScore + " and held by " + highScorePlayer);
        }
    }

}

