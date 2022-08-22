using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}