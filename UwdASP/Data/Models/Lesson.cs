using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UwdASP.Data.Models
{
    public class Lesson
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }
    }
}
