using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UwdASP.Data.Models
{
    public class Schedule
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Lesson")]
        public long LessonId { get; set; }

        public virtual Lesson Lesson { get; set; }

        [ForeignKey("Group")]
        public long GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
