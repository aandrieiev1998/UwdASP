using System.ComponentModel.DataAnnotations;

namespace UwdASP.Data.Models
{
    public class Group
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public int Semester { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
    }
}
