using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 1, ErrorMessage ="Please, enter a movie title." )]
        public string Title { get; set; }
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name ="Release Date")]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2020")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", 
            ErrorMessage =("Please enter a genre starting with an uppercase letter: Action"))]

        public string Genre { get; set; }

        [Required]
        [Range(.01, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Please enter a genre starting with an uppercase letter: Action")
            ]
        [StringLength(5)]
        public string Rating { get; set; }

        //^ = beginning of line
        //[A-Z] first character must be upper case
        //+ and
        //[a-z or A-Z or ' or - or space
        //* any number of times
        //$ end of line

    }
}
