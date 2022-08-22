using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Cart_Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Sessionid { get; set; }
        [ForeignKey("Sessionid")]
        public virtual Shoping_Session Shoping_SessionId { get; set; }

        [Required]
        public int BooksId { get; set; }
        [ForeignKey("BooksId")]
        public virtual Book Books { get; set; }

        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}