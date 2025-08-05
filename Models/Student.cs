using System.ComponentModel.DataAnnotations;

namespace CodeFirst1.Models
{
    public class Student
    {
        [Key]
        public int StuId { get; set; }
        public string StuName { get; set; }
        public int StuAge { get; set; }
        public string group { get; set; }

    }
}
