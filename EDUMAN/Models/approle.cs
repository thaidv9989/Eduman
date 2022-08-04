using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class approle : baseEntity
    {
        [Key]
        public string role_id { get; set; }
        public string role_name { get; set; }
        public string description { get; set; }
        
        
    }
}
