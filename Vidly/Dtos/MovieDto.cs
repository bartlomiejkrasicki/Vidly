﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public GenreDto Genre { get; set; }

        [Required]
        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime AddedDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in stock")]
        public int NumberInStock { get; set; }
    }
}