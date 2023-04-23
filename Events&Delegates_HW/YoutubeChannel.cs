using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegates_HW
{
    public class YoutubeChannel
    {
        public string Name { get; set; }
        public Category VideoCategory { get; set; }
        public List<Videos> Video { get; set; }

        public YoutubeChannel(string name, Category category)
        {
            Name = name;
            VideoCategory = category;
            Video = new List<Videos>();
        }

        public delegate void YoutubeDelegate(Videos video);

        public event YoutubeDelegate Subscribers;

        public void Subscribe(YoutubeDelegate subscribeMethod)
        {
            Subscribers += subscribeMethod;
        }
        public void Unsubscribe(YoutubeDelegate subscribeMethod)
        {
            Subscribers -= subscribeMethod;
        }

        public void UploadVideoToChannel(Videos video)
        {
            Video.Add(video);

            if (Subscribers != null && Subscribers.GetInvocationList().Length > 0)
            {
                Subscribers(video);
            }
            else
            {
                Console.WriteLine("No subscribers");
            }
        }
    }
}
