using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        //public string Genre { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public GenreDto Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Required]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}
