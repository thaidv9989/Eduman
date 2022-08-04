using EDUMAN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUMAN.EntityConfiguration
{
    public class RewardConfig : IEntityTypeConfiguration<reward>
    {
        public void Configure(EntityTypeBuilder<reward> builder)
        {

        }
    
    }
}
