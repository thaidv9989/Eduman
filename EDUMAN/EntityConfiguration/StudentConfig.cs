using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class StudentConfig : IEntityTypeConfiguration<student>
    {
        public void Configure(EntityTypeBuilder<student> builder)
        {
            builder.HasOne<e_class>()
                .WithMany()
                .HasForeignKey(c => c.class_id);
        }
    
    }
}
