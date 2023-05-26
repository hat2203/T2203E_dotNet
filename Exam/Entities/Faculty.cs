using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam.Entities
{
    [Table ("Faculties")]
    public class Faculty
    {
        [Key] public int Id { get; set; }

        [Required]
        [StringLength (255)]
        public string Name { get; set; }
    }
}
