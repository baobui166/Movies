using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesBooking.Models
{
    public class Receipt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ReceiptId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        // Other properties as needed
        [ForeignKey("UserId")]
        public virtual UserInfo User { get; set; }
        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
    }

}
