using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class HeroConfiguration : BaseConfiguration<Hero>
    {
        public override void Configure(EntityTypeBuilder<Hero> builder)
        {
            base.Configure(builder);
            builder.HasKey(p => p.HeroID);
        }
    }
}
