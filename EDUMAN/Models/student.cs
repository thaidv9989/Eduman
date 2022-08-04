using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDUMAN.Models
{
    public class student : baseEntity
    {
        [Key]
        public string student_id { get; set; }
        public string img { get; set; }
        public string fullname { get; set; }
        public bool gender { get; set; }
        public string country { get; set; }
        public DateTime date_of_birth { get; set; }
        public string place_of_birth { get; set; }
        public string domicile { get; set; }
        public string household { get; set; }
        public string ethnicity { get; set; }
        public string religion { get; set; }
        public string recruitment_area { get; set; }
        public string subject { get; set; }
        public string morality { get; set; }
        public string education_level { get; set; }
        public string policy_type { get; set; }
        public string family_category { get; set; }
        public DateTime communist_youth_day { get; set; }
        public DateTime communist_party_day { get; set; }
        public string identity_number { get; set; }
        public DateTime identity_date { get; set; }
        public string identity_place { get; set; }
        public string bank_account { get; set; }
        public string email { get; set; }
        public string contact_address { get; set; }
        public string phone { get; set; }
        public string class_id { get; set; }
        public string description { get; set; }
        public string state { get; set; }
       
        
    }
}
