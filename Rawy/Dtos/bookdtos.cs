using core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rawy.Dtos
{
    public class bookdtos
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string BookTitle { get; set; }

        public string book { get; set; }
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
        public string catygoriesname { get; set; }
        public string favoritesname { get; set; }

        //public ICollection<Review> reviews { get; set; } = new HashSet<Review>();
        //public ICollection<Catygory> catygories { get; set; } = new HashSet<Catygory>();
        //public ICollection<Favorite> favorites { get; set; } = new HashSet<Favorite>();
        [Required]
        public int AurthorId { get; set; }
        [ForeignKey("AurthorId")]
        [Required]
     public string Aurthorname { get; set; }
    }
}
