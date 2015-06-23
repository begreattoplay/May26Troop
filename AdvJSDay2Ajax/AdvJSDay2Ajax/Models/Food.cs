using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvJSDay2Ajax.Models
{
    public class Food
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Food Name is required fool")]
        public string Name { get; set; }
    }
}