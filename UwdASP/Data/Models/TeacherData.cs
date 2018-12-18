using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace UwdASP.Data.Models
{
    public class TeacherData
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }
        public virtual User Identity { get; set; }
    }
}
