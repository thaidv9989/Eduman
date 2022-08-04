using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class StudentDisciplineConfig : IEntityTypeConfiguration<student_discipline>
    {
        public void Configure(EntityTypeBuilder<student_discipline> builder)
        {
            
            builder.HasOne<student>()
                .WithMany()
                .HasForeignKey(s => s.student_id);
            builder.HasOne<discipline>()
                .WithMany()
                .HasForeignKey(s => s.discipline_id);
        }
    
    }
}
