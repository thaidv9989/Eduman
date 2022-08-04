using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class approle_permission : baseEntity
    {
        [Key]
        public int id { get; set; }
        public string role_id { get; set; }
        public string permission_id { get; set; }
        
    }
}
