using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesBooking.Models
{
    public class PremiereTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PremiereTimeId { get; set; }
        [Required]
        [DisplayName("Giờ chiếu")]
        public DateTime StartTime { get; set; }
    }
}
