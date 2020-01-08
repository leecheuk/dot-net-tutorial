using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovies.Models {
    public class Movie {
        // primary ID
        public int ID { get; set; }

        public string Title { get; set; }

        // show date only
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}