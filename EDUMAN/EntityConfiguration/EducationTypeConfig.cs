using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class EducationTypeConfig : IEntityTypeConfiguration<education_type>
    {
        public void Configure(EntityTypeBuilder<education_type> builder)
        {

        }
    }
}
