using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Models
{
    public class Book:BaseClass
    {

        [Required]
        [MaxLength(200)]
        public string BookTitle { get; set; }
        [Required]
        public string bookurl { get; set; }
        [Required]
        [MaxLength(100)]
        public string Author { get; set; }

        [MaxLength(100)]
        public string? Narrator { get; set; }

        [Required]
        public string Language { get; set; }

        public DateTime? ReleaseDate { get; set; }
        [Required]
        public string CoverImage { get; set; }
        public ICollection<Review> reviews { get; set; } = new HashSet<Review>();
        public ICollection<Catygory> catygories { get; set; } = new HashSet<Catygory>();
        public ICollection<Favorite> favorites { get; set; } = new HashSet<Favorite>();
        [Required]
        public int AurthorId { get; set; }
        [ForeignKey("AurthorId")]
        [Required]
        public Aurthor Aurthor { get; set; }



    }
}
