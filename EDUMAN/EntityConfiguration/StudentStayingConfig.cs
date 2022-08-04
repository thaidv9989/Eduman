using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class StudentStayingConfig : IEntityTypeConfiguration<student_staying>
    {
        public void Configure(EntityTypeBuilder<student_staying> builder)
        {
            builder.HasOne<student>()
                .WithMany()
                .HasForeignKey(x => x.student_id);
        }
    
    }
}
