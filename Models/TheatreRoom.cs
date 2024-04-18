using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesBooking.Models
{
    public class TheatreRoom
    {
        [DisplayName("Mã phòng")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int TheatreRoomId { get; set; }
        [Required]
        public int TheatreId { get; set; }
        [Required]
        [DisplayName("Tên phòng")]
        public string Name { get; set; }

        // Other properties as needed
        [ForeignKey("TheatreID")]

        public virtual Theatre Theatre { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
    }
}
