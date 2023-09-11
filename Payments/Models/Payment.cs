using System;
using System.ComponentModel.DataAnnotations;

namespace Payments.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
