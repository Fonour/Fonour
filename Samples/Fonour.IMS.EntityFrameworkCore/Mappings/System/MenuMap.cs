using Abp.EntityFrameworkCore.Mappings;
using Fonour.IMS.Domain.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fonour.IMS.EntityFrameworkCore.Mappings.System
{
   public class MenuMap : EntityMappingConfiguration<Menu>
    {
        public override void Map(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("System_Menu").HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Code).HasMaxLength(50);
            builder.Property(p => p.Url).HasMaxLength(200);
            builder.Property(p => p.Icon).HasMaxLength(50);
            builder.Property(p => p.Remarks).HasMaxLength(500);
        }
    }
}
