using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UwdASP.Data.Models
{
    public class StudentData
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }
        public virtual User Identity { get; set; }

        [ForeignKey("Group")]
        public long GroupId { get; set; }
        public virtual Group Group { get; set; }

        [Required]
        [ForeignKey("Specialization")]
        public long SpecializationId { get; set; }
        public virtual Specialization Specialization { get; set; }

        [Required]
        public StudyType StudyType { get; set; }

        [Required]
        public DateTime StudyBeginningDate { get; set; }

        [Required]
        public int Semester { get; set; }

        [Required]
        public int Index { get; set; }

        public float Balance { get; set; }

        public int BankAccountNumber { get; set; }
    }

    public enum StudyType
    {
        Stationary,
        Correspondence
    }
}
