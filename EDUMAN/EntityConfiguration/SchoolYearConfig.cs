using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class SchoolYearConfig : IEntityTypeConfiguration<school_year>
    {
        public void Configure(EntityTypeBuilder<school_year> builder)
        {
            builder.HasOne<education_type>()
                .WithMany()
                .HasForeignKey(s => s.education_type_id);
        }
    
    }
}
