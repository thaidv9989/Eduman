using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class ClassConfig : IEntityTypeConfiguration<e_class>
    {
        public void Configure(EntityTypeBuilder<e_class> builder)
        {
            builder.HasOne<major>()
                .WithMany()
                .HasForeignKey(c => c.major_id);
            builder.HasOne<teacher>()
                .WithMany()
                .HasForeignKey(c => c.teacher_id);
        }
    
    }
}
