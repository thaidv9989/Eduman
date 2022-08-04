using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class student_relative : baseEntity
    {
        [Key]
        public int id { get; set; }
        public string relative_type { get; set; }
        public string relative_fullname { get; set; }
        public DateTime date_of_birth { get; set; }
        public string household { get; set; }
        public string job { get; set; }
        public string description { get; set; }
        public string student_id { get; set; }
        
    }
}
