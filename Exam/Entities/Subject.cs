using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam.Entities
{
    [Table ("Subjects")]
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength (255)]
        public string Name { get; set; }
    }
}
