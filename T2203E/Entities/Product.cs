using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace T2203E.Entities
{
    
        [Table("Products")]
        public class Product
        {
            [Key]// khoá chính
            public int Id { get; set; }

            [Required]
            [StringLength(255)]
            public string Name { get; set; }


            [Required]
            public double Price { get; set; }

            [StringLength(150)]
            public string thumbnail { get; set; }
        }
 }