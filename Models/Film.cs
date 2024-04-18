using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesBooking.Models
{
    public class Film
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã phim")]
        public int FilmId { get; set; }
        [Required]
        public string NameFilm{ get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string PosterUrl { get; set; }
        [Required]
        public string TrailerUrl { get; set; }
        [Required]
        public DateTime PremiereDate { get; set; }
        [Required]
        public DateTime EndingDate { get; set; }
        [Required] 
        public int FilmDuration { get; set; }
        [Required]
        public int FilmCategoryId { get; set; }
        // Other properties as needed
        [ForeignKey(nameof(FilmCategoryId))]
        public virtual FilmCategory FilmCategory { get; set; }
    }
}
