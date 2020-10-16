namespace backend_netcore.Models.Users
{
    //model is there got GET requests to prevent the password from being exposed
    public class UserModel
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Gender {get; set;}
        public string Email {get; set;}
        public string Username {get; set;}
    }
}