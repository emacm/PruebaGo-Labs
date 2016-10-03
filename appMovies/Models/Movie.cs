using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appMovies.Models
{
        [Table("Movies")]
        public class Movie
        {
            [Key]
            public int Id { get; set; }
            public string Title { get; set; }        
            public string Description { get; set; }
            public string Year { get; set; }
            public string Director { get; set; }

        }
}

