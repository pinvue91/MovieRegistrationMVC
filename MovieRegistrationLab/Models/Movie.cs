using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieRegistrationLab.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength =1, ErrorMessage = "Character limit for Title is 50.")]
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

    }
}
