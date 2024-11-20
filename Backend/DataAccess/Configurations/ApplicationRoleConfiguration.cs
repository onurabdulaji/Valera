using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class ApplicationRoleConfiguration : BaseConfiguration<ApplicationRole>
    {
        public override void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            base.Configure(builder);
            builder.ToTable("Roles"); // Tablo adı (varsayılan: AspNetRoles)
            builder.Property(r => r.Description)
              .HasMaxLength(256) // Maksimum uzunluk
              .IsRequired(false); // Opsiyonel bir alan
        }
    }
}
