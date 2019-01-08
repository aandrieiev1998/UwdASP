using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UwdASP.Data.Models.Bookkeepings
{
    public class Bookkeeping
    {
        [Key]
        public long Id { get; set; }
        
        [ForeignKey(("Teacher"))]
        public long StudentDataId { get; set; }
        public virtual StudentData StudentData { get; set; }

        [Required]
        public float Amount { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        [Required]
        public float BalanceAfterTransaction { get; set; }
    }
}
