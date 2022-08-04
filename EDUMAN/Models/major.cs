using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class major : baseEntity
    {
        [Key]
        public int major_id { get; set; }
        public string major_name { get; set; }
        public string description { get; set; }
        public string major_type { get; set; }
        public string major_related { get; set; }
        public int school_year_id { get; set; }
        
    }
}
