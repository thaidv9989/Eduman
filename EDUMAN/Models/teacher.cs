using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class teacher : baseEntity
    {
        [Key]
        public string teacher_id { get; set; }
        public string teacher_name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime DOB { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        
    }
}
