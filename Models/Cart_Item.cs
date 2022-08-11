using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Cart_Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Sessionid { get; set; }
        [ForeignKey ("Sessionid")]
        public virtual Shoping_Session Shoping_SessionId { get; set; }
        [Required]
        public int Bookid { get; set; }

        [ForeignKey ("Bookid")]
        public virtual int BookId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}