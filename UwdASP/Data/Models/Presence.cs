using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UwdASP.Data.Models
{
    public class Presence
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("StudentData")]
        public long StudentId { get; set; }

        public virtual StudentData StudentData { get; set; }

        [ForeignKey("Lesson")]
        public long LessonId { get; set; }

        public virtual Lesson Lesson { get; set; }

        [Required]
        public DateTimeOffset Date { get; set; }
    }
}
