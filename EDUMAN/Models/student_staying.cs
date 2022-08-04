using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class student_staying : baseEntity
    {
        [Key]
        public int id { get; set; } 
        public DateTime from_date { get; set; }
        public DateTime to_date { get; set; }
        public string type { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public string host_name { get; set; }
        public string description { get; set; }
        public string student_id { get; set; }
        
    }
}
