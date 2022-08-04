using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class school_year : baseEntity
    {
        [Key]
        public int school_year_id { get; set; }
        public string school_year_name { get; set; }
        public string description { get; set; }
        public DateTime from_date { get; set; }
        public DateTime to_date { get; set; }
        public int education_type_id { get; set; }
        
    }
}
