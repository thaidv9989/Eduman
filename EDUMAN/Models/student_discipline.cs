using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class student_discipline : baseEntity
    {
        [Key]
        public int id { get; set; }
        public string student_id { get; set; }
        public int discipline_id { get; set; }
        public string semester { get; set; }
        public string discipline_reason { get; set; }
        public string decision { get; set; }
        public DateTime expired_on { get; set; }


    }
}
