using System.ComponentModel.DataAnnotations;

namespace ONEZEROHOTEL.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required, MinLength(6)]
        public string Password { get; set; }
        [Required, MinLength(6)]
        public string ConfirmPassword { get; set; }

    }
}
