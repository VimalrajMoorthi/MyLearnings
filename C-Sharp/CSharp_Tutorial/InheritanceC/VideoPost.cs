using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceC
{
    class VideoPost : Post
    {
        // Member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        // Properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost(){ }

        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            // The following properties and the GetNextID method are inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // The following Properties are member of VideoPost, but not of Post
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Video is playing!");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Video is stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
        }
    }
}
