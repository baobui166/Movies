using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesBooking.Models
{
    public class TicketDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int TicketDetailId { get; set; }
        [Required]
        public int TicketId { get; set; }
        [Required]
        public int SeatId { get; set; }
        [Required]
        public decimal Price { get; set; }
        // Other properties as needed
        [ForeignKey(nameof(TicketId))]
        public virtual Ticket Ticket { get; set; }
        [ForeignKey(nameof(SeatId))]
        public virtual Seat Seat { get; set; }
    }

}
