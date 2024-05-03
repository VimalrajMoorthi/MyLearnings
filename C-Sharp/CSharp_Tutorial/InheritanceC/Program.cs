using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Vimalraj Moorthi");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost = new ImagePost("Check out my new shoes", "Vimalraj Moorthi", "https://images.com/shoes", true);
            Console.WriteLine(imagePost.ToString());
            
            VideoPost videoPost1 = new VideoPost("Check out my video", "Vimalraj Moorthi", "https://videos.com/shoes", 10, true);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
            
            Console.ReadLine();
        }

        // CHALLENGE add a deriving class "VideoPost" with a property VideoURL, Length

        // create the required constructors to create a VideoPost
        // adjust the ToString() method accordingly
        // create an instance of VideoPost and use the ToString method on it.

        // More advanced - use Timer and a Callback method here (google it :))
        // create fields as required
        // add member methods "Play" which should write the current duration of the video
        // and "Stop" which should stop the "timer" and write "Stopped at {0}s" onto the console.
        // Play the video after creating the instance and pause it, when the user presses any key.



    }
}
