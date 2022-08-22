using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Booksid { get; set; }
        [ForeignKey("Booksid")]
        public virtual Book BookId { get; set; }
        [Required]
        public int Usersid { get; set; }
        [ForeignKey("Usersid")]
        public virtual User UserId { get; set; }
        public int Total { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
    }
}