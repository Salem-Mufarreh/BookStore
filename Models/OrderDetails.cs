using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Bookid { get; set; }
        [ForeignKey ("Bookid")]
        public virtual Book BookId { get; set; }
        [Required]
        public int Userid { get; set; }
        [ForeignKey("Userid")]
        public virtual User UserId { get; set; }
        public int Total { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
    }
}