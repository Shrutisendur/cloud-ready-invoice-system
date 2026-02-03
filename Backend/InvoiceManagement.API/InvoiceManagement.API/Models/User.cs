using System.ComponentModel.DataAnnotations;

namespace InvoiceManagement.API.Models
{
    public class User
    { 
        public string Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
