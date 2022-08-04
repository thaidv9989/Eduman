using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class DisciplineConfig : IEntityTypeConfiguration<discipline>
    {
        public void Configure(EntityTypeBuilder<discipline> builder)
        {

        }
    
    }
}
