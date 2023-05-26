using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam.Entities
{
    [Table ("Exams")]
    public class Exam
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        [StringLength(255)]
        [Required]
        public TimeOnly Time { get; set; }

        [StringLength(255)]
        [Required]
        public DateTime Date { get; set; }

        [StringLength(255)]
        [Required]
        public int Duration { get; set; }

        [StringLength(255)]
        [Required]
        public int ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }

        [StringLength(255)]
        [Required]
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}
