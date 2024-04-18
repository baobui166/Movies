using Microsoft.AspNetCore.Cors;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesBooking.Models
{
    public class FilmCategory
    {
        [Key]
        [Required]
        [DisplayName("Mã loại phim")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilmCategoryId { get; set; }
        [Required]
        [DisplayName("Mô tả")]
        public string Description { get; set; }
    }
}
