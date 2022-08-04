using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class education_type : baseEntity
    {
        [Key]
        public int education_type_id { get; set; }
        public string education_type_name { get; set; }
        public string description { get; set; }
        
    }
}
