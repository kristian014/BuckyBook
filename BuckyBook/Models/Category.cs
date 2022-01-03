using System.ComponentModel.DataAnnotations;

namespace BuckyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        [Range(1,100, ErrorMessage ="Display order must be within 1-100")]
        public int DisplayOrder { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
