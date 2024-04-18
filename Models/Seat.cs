using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesBooking.Models
{
    public class Seat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã ghế")]
        public int SeatId { get; set; }
        [Required]
        public int TheatreRoomId { get; set; }
        [Required]
        [DisplayName("Số ghế")]
        public string SeatNumber { get; set; }
        [DisplayName("Tình trạng ghế")]
        [Required]
        public bool IsBooked { get; set; }
        // Other properties as needed
        [ForeignKey("TheatreRoomId")]
        public virtual TheatreRoom TheatreRoom { get; set; }
        public virtual ICollection<TicketDetail> TicketDetails { get; set; }
    }

}
