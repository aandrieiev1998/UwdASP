using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UwdASP.Data.Models;

namespace UwdASP.Data.Models
{
    public class TeacherGroup
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Teacher")]
        public long TeacherId { get; set; }

        public virtual TeacherData TeacherData { get; set; }

        [ForeignKey("Group")]
        public long GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
