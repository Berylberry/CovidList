namespace backend_netcore.Entities
{
    public class Church
    {
        public int Id {get; set;}
        public string Location {get; set;}
        public string District {get; set;}
        public string Region {get; set;}
        public string PastorName {get; set;}
        public bool Onboard {get; set;}
    }
}