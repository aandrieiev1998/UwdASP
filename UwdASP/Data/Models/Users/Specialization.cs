using System.ComponentModel.DataAnnotations;

namespace UwdASP.Data.Models
{
    public class Specialization
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
