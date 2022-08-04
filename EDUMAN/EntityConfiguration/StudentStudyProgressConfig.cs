using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class StudentStudyProgressConfig : IEntityTypeConfiguration<student_study_progress>
    {
        public void Configure(EntityTypeBuilder<student_study_progress> builder)
        {
            builder.HasOne<student>()
                .WithMany()
                .HasForeignKey(p => p.student_id);
        }
    
    }
}
