using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class TeacherApprolesConfig : IEntityTypeConfiguration<teacher_approle>
    {
        public void Configure(EntityTypeBuilder<teacher_approle> builder)
        {
            builder.HasOne<teacher>()
                .WithMany()
                .HasForeignKey(t => t.teacher_id);
            builder.HasOne<approle>()
                .WithMany()
                .HasForeignKey(a=>a.role_id);

        }
    }
}
