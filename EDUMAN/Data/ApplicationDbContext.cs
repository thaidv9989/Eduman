using EDUMAN.EntityConfiguration;
using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;

namespace EDUMAN.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<student> students { get; set; }
        public DbSet<teacher> teachers { get; set; }
        public DbSet<e_class> classes { get; set; }
        public DbSet<major> majors { get; set; }
        public DbSet<education_type> education_types { get; set; }
        public DbSet<school_year> school_years { get; set; }
        public DbSet<student_relative> student_relatives { get; set; }
        public DbSet<reward> rewards { get; set; }
        public DbSet<discipline> disciplines { get; set; }
        public DbSet<student_reward> student_rewards { get; set; }
        public DbSet<student_staying> student_stayings { get; set; }
        public DbSet<student_study_log> student_study_logs { get; set; }
        public DbSet<student_study_progress> student_study_progresses { get; set; }
        public DbSet<student_discipline> student_disciplines { get; set; }
        public DbSet<approle> approles { get; set; }
        public DbSet<teacher_approle> teacher_approles { get; set; }
        public DbSet<permission> permissions { get; set; }
        public DbSet<approle_permission> approle_permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClassConfig());
            builder.ApplyConfiguration(new DisciplineConfig());
            builder.ApplyConfiguration(new EducationTypeConfig());
            builder.ApplyConfiguration(new MajorConfig());
            builder.ApplyConfiguration(new RewardConfig());
            builder.ApplyConfiguration(new SchoolYearConfig());
            builder.ApplyConfiguration(new StudentConfig());
            builder.ApplyConfiguration(new StudentDisciplineConfig());
            builder.ApplyConfiguration(new StudentRelativeConfig());
            builder.ApplyConfiguration(new StudentRewardConfig());
            builder.ApplyConfiguration(new StudentStayingConfig());
            builder.ApplyConfiguration(new StudentStudyLogConfig());
            builder.ApplyConfiguration(new StudentStudyProgressConfig());
            builder.ApplyConfiguration(new ApprolePermissionConfig());
            builder.ApplyConfiguration(new TeacherApprolesConfig());

        }
    }
    
}
