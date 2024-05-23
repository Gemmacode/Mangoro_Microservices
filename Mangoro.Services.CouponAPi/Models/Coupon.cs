using System.ComponentModel.DataAnnotations;

namespace Mangoro.Services.CouponAPi.Models
{
    public class Coupon
    {
        [Required]
        public int CouponId { get; set; } 
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; } 
        public int MinAmount { get; set; } 
    }
}
