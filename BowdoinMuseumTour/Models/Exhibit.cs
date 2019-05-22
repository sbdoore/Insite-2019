using System;
using System.Collections.Generic;

namespace BowdoinMuseumTour
{
    public class Exhibit
    {
        public string Title { get; set; }
        public List<Zone> Zones {get; set;}
        public List<Hazard> Hazards {get; set;}
        
    }
}
