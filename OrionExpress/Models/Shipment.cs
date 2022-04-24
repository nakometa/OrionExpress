using Microsoft.AspNetCore.Identity;
using OrionExpress.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace OrionExpress.Models
{
    public class Shipment
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }

        [Required]
        public CargoType Type { get; set; }

        [Required]
        public string Sender { get; set; }

        [Required]
        public string Recipient { get; set; }

        [Required]
        public DateTime SentDate { get; set; } = DateTime.UtcNow;

        public double? ServiceFee { get; set; }
    }
}
