using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class StudentRelativeConfig : IEntityTypeConfiguration<student_relative>
    {
        public void Configure(EntityTypeBuilder<student_relative> builder)
        {
            builder.HasOne<student>()
                .WithMany()
                .HasForeignKey(s => s.student_id);
        }
    
    }
}
