using System;

namespace BowdoinMuseumTour
{
    public class Artwork
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public string Medium { get; set; }
        //public string RelativeLocationOnWall {get; set;}

        public Artwork(string title, string artist, string description)
        {
            Title = title;
            Artist = artist;
            Description = description;
            CreationDate = "unknown date";
            Medium = "unknown medium";
        }

        public Artwork(string title, string artist, string description, string date, string medium)
        {
            Title = title;
            Artist = artist;
            Description = description;
            CreationDate = date;
            Medium = medium;
        }
    }

}
