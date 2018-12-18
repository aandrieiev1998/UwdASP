using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UwdASP.Data.Models
{
    public class Mark
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Lesson")]
        public long LessonId { get; set; }
        public virtual Lesson Lesson { get; set; }

        [ForeignKey("Teacher")]
        public long TeacherDataId { get; set; }
        public virtual TeacherData TeacherData { get; set; }

        [ForeignKey("Student")]
        public long StudentDataId { get; set; }
        public virtual StudentData StudentData { get; set; }

        [Required]
        public float Value { get; set; }

        public DateTimeOffset Date { get; set; }

        [Required]
        public MarkType MarkType { get; set; }

        public string Comment { get; set; }
    }

    public enum MarkType
    {
        Regular,
        Final
    }
}
