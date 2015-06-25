using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NickCafe.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string  Name  { get; set; }
        public decimal ProductPrice { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        public bool IsBreakfast { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }


}