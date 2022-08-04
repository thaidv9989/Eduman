using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class StudentStudyLogConfig : IEntityTypeConfiguration<student_study_log>
    {
        public void Configure(EntityTypeBuilder<student_study_log> builder)
        {
            builder.HasOne<student>()
                .WithMany()
                .HasForeignKey(l => l.student_id);
            
        }
    
    }
}
