using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class StudentRewardConfig : IEntityTypeConfiguration<student_reward>
    {
        public void Configure(EntityTypeBuilder<student_reward> builder)
        {
            
            builder.HasOne<student>()
                .WithMany()
                .HasForeignKey(s => s.student_id);
            builder.HasOne<reward>()
                .WithMany()
                .HasForeignKey(s => s.reward_id);
        }
    
    }
}
