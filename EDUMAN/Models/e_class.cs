using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class e_class : baseEntity
    {
        [Key]
        public string class_id { get; set; }
        public string class_name { get; set; }
        public string description { get; set; }
        public string teacher_id { get; set; }
        public int major_id { get; set; }
        
    }
}
