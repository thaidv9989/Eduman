using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class discipline : baseEntity
    {
        [Key]
        public int discipline_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        
    }
}
