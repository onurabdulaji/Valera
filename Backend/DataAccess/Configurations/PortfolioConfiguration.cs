using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class PortfolioConfiguration : BaseConfiguration<Portfolio>
    {
        public override void Configure(EntityTypeBuilder<Portfolio> builder)
        {
            base.Configure(builder);
            builder.HasKey(p=>p.PortfolioID);
        }
    }
}
