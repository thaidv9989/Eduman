using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class ApprolePermissionConfig : IEntityTypeConfiguration<approle_permission>
    {
        public void Configure(EntityTypeBuilder<approle_permission> builder)
        {
            builder.HasOne<approle>()
                .WithMany()
                .HasForeignKey(a => a.role_id);
            builder.HasOne<permission>()
                .WithMany()
                .HasForeignKey(p => p.permission_id);
        }
    }
}
