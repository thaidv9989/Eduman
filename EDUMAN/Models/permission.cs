﻿using System.ComponentModel.DataAnnotations;

namespace EDUMAN.Models
{
    public class permission : baseEntity
    {
        [Key]
        public string permission_id { get; set; }
        public string permission_name { get; set; }
        public string description { get; set; }
        public string module { get; set; }

        
    }
}
