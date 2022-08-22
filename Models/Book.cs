using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public double Price { get; set; }

    }
}