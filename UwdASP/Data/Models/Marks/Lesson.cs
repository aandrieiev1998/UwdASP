using System.ComponentModel.DataAnnotations;

namespace UwdASP.Data.Models.Marks
{
    public class Lesson
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }
    }
}
