using System;
using UwdASP.Data.Models;
using UwdASP.Data.Models.Marks;

namespace UwdASP.API.Models
{
    public class AddMarkRequest
    {
        public long LessonId { get; set; }
        public long UserId { get; set; }
        public float Value { get; set; }
        public DateTime Date { get; set; }
        public MarkType MarkType { get; set; }
        public string Comment { get; set; }
    }
}
