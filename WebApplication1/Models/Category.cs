using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]

        [StringLength(250)]
        public string Name { get; set; }
    }
}