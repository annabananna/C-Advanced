using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegates_HW
{
    public class Videos
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        public Videos(string title, string description, int duration)
        {
            Title = title;
            Description = description;
            Duration = duration;
        }
    }
}
