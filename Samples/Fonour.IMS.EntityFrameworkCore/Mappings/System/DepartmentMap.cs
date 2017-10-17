using Abp.EntityFrameworkCore.Mappings;
using Fonour.IMS.Domain.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fonour.IMS.EntityFrameworkCore.Mappings.System
{
    public class DepartmentMap : EntityMappingConfiguration<Department>
    {
        public override void Map(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("System_Department").HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Code).HasMaxLength(200);
            builder.Property(p => p.Manager).HasMaxLength(50);
            builder.Property(p => p.ContactNumber).HasMaxLength(20);
            builder.Property(p => p.Remarks).HasMaxLength(500);
        }

    }
}
