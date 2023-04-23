namespace Events_Delegates_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YoutubeChannel travelChannel = new YoutubeChannel("Travel Channel", Category.Entertainment);

            YoutubeChannel natureChannel = new YoutubeChannel("Nature Channel", Category.Education);

            Subscriber s1 = new Subscriber("ana123");
            Subscriber s2 = new Subscriber("test123");
            Subscriber s3 = new Subscriber("test987");

            travelChannel.Subscribe(s1.SeeUploadedVideoOnChannel);
            travelChannel.Subscribe(s2.SeeUploadedVideoOnChannel);

            natureChannel.Subscribe(s1.SeeUploadedVideoOnChannel);
            natureChannel.Subscribe(s3.SeeUploadedVideoOnChannel);

            Videos travel1 = new Videos("Italy", "10 Days in Italy", 3000);
            Videos travel2 = new Videos("Pariz GetAway", "How to spend 4 days in Pariz", 2000);

            Videos nature1 = new Videos("Etna", "Volcanos around the world part1", 1500);
            Videos nature2 = new Videos("Events and Delegates", "Events and Delegates in C#", 2200);


            travelChannel.UploadVideoToChannel(travel1);
            travelChannel.UploadVideoToChannel(travel2);

            natureChannel.UploadVideoToChannel(nature1);
            natureChannel.UploadVideoToChannel(nature2);
        }
    }
}