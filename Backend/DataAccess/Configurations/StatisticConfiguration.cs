﻿using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class StatisticConfiguration : BaseConfiguration<Statistic>
    {
        public override void Configure(EntityTypeBuilder<Statistic> builder)
        {
            base.Configure(builder);
            builder.HasKey(p=> p.StatisticID);
        }
    }
}