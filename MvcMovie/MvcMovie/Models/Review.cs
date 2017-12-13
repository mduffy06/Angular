using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Review
    {


        public int ID { get; set; }

        [Display(Name = "Please enter your name")]
        [Required(ErrorMessage = "Name is required")]
        public string Reviewer { get; set; }

        [Display(Name = "Type your review here")]
        [Required(ErrorMessage = "Field is required")]
        public string Comment { get; set; }

        public int MovieID { get; set; }

        public Movie movie { get; set; }
    }
}
