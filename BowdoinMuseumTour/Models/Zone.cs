using System;
using System.Collections.Generic;

namespace BowdoinMuseumTour
{
    public class Zone
    {
        public int ZoneID { get; set; }
        public string RelativeLocationInRoom {get;}
        public List<Artwork> ArtworkCollection {get; set;}
        public Viewpoint ViewpointTag {get; set;}
        // TODO: Check if only one tage per zone


        public Zone(int id, string roomLocation)
        {
            ZoneID = id;
            RelativeLocationInRoom = roomLocation;
        }





    }

}
