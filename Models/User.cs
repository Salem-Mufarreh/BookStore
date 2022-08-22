using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public string password { get; set; }
        public string Active { get; set; }

    }
}