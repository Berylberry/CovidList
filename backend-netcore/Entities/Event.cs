using System;

namespace backend_netcore.Entities
{
    public class Event
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public DateTime StartTime {get; set;}
        public DateTime EndTime {get; set;}
    }
}