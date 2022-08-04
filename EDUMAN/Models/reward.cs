using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class reward : baseEntity
    {
        [Key]
        public int reward_id { get; set; }
        public string reward_name { get; set; }
        public string description { get; set; }
        
    }
}
