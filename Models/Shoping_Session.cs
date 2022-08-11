﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Shoping_Session
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UsersId { get; set; }
        [ForeignKey("UsersId")]
        public virtual User User { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}