using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Web.Models
{
    public class CountModel
    {
        public int Id { get; set; }

        [Display(Name = "Count Number")]
        public int CountNumber { get; set; }

    }
}