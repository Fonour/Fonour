using Abp.EntityFrameworkCore.Mappings;
using Fonour.IMS.Domain.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fonour.IMS.EntityFrameworkCore.Mappings.System
{
    public class UserMap : EntityMappingConfiguration<User>
    {
        public override void Map(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("System_User").HasKey(p => p.Id);
            builder.HasAlternateKey(p => p.UserName);
            builder.Property(p => p.UserName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Password).HasMaxLength(50);
            builder.Property(p => p.EMail).HasMaxLength(50);
            builder.Property(p => p.MobileNumber).HasMaxLength(11);
            builder.Property(p => p.Remarks).HasMaxLength(500);
        }
    }
}
