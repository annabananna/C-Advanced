using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegates_HW
{
    public class Subscriber
    {
        public string UserName { get; set; }

        public Subscriber(string username)
        {
            UserName = username;
        }

        public void SeeUploadedVideoOnChannel(Videos video)
        {
            Console.WriteLine($"{UserName}, have received info that new video {video.Title} is uploaded to the channel i am subscribed to and it last {video.Duration} seconds ");
        }
    }
}
