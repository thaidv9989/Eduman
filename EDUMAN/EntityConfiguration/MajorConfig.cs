using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class MajorConfig : IEntityTypeConfiguration<major>
    {
        public void Configure(EntityTypeBuilder<major> builder)
        {
            builder.HasOne<school_year>()
                .WithMany()
                .HasForeignKey(m => m.school_year_id);
        }
    
    }
}
