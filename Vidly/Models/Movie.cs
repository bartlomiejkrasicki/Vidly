﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }

        [Display( Name = "Genre" )]
        public int GenreId { get; set; }

        [Required]
        [Display( Name = "Release date" )]
        public DateTime ReleaseDate { get; set; }

        public DateTime AddedDate { get; set; }

        [Required]
        [Range(1,20)]
        [Display(Name = "Number in stock")]
        public int NumberInStock { get; set; }
    }
}