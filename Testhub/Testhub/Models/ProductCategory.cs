using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testhub.Models
{
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CategoryID { get; set; }

        [Required]
        [MaxLength(20)]
        public string CategoryName { get; set; }

        public virtual ProductCategory ParentCategory { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}