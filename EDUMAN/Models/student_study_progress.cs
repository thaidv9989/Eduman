namespace EDUMAN.Models
{
    public class student_study_progress : baseEntity
    { 
        public int id { get; set; }
        public DateTime from_date { get; set; }
        public DateTime to_date { get; set; }
        public string activity { get; set; }
        public string place { get; set; }
        public string student_position { get; set; }
        public string student_id { get; set; }
        
    }
}
