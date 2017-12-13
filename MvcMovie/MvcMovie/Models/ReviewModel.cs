using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class ReviewModel
    {
        public List<Review> reviews;
        public Movie movie { get; set; }
        
    }
}
