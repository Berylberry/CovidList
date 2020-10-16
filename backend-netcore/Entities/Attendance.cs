using System;

namespace backend_netcore.Entities
{
    public class Attendance
    {
        public int Id {get; set;}
        public User User {get; set;}
        public Church Church {get; set;}
        public Event Event {get; set;}
        public Location Location {get; set;}
        public Member Member {get; set;}
        public double Temperature {get; set;}
        public DateTime Time {get; set;}
    }
}