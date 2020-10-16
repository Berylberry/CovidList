using System.ComponentModel.DataAnnotations;

namespace backend_netcore.Models.Users
{
    public class RegisterModel
    {
        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName {get; set;}
        [Required]
        public string Gender {get; set;}
        public string Email {get; set;}
        [Required]
        public string Username {get; set;}
        [Required]
        public string Password {get; set;}
    }
}