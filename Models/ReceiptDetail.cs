using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesBooking.Models
{
    public class ReceiptDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceiptDetailId { get; set; }
        [Required]
        public int ReceiptId { get; set; }
        [Required]
        public int FilmScheduleId { get; set; }
        [Required]
        public int SeatId { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        // Other properties as needed
        [ForeignKey("ReceiptId")]
        public virtual Receipt Receipt { get; set; }
        [ForeignKey("FilmScheduleId")]
        public virtual FilmSchedule FilmSchedule { get; set; }
        [ForeignKey("SeatId")]
        public virtual Seat Seat { get; set; }
    }

}
