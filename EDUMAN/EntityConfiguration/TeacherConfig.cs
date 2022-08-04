using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class TeacherConfig : IEntityTypeConfiguration<teacher>
    {
        public void Configure(EntityTypeBuilder<teacher> builder)
        {

        }
    
    }
}
