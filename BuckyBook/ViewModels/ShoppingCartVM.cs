using System.ComponentModel.DataAnnotations;
using BuckyBook.Models;

namespace BuckyBook.ViewModels
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> ListCart { get; set; } 

        //public double CartTotal { get; set; }

        public OrderHeader OrderHeader { get; set; }


        [Required]
        public string PhoneNumber { get; set; }

       
        public string ApplicationUserId { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }

        //[Required]
        //public string? State { get; set; } = "null";

        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
