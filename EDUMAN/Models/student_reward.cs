using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class student_reward : baseEntity
    {
        [Key]
        public int id { get; set; }
        public string student_id { get; set; }
        public int reward_id { get; set; }
        public string semester { get; set; }
        public string reward_reason { get; set; }
        public string decision { get; set; }
        
    }
}
