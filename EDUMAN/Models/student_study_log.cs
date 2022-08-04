using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class student_study_log : baseEntity
    {
        [Key]
        public int id { get; set; }
        public string log_content { get; set; }
        public string student_id { get; set; }
        public DateTime time { get; set; }
        
    }
}
