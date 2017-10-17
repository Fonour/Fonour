using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Mappings;
using Fonour.IMS.Domain.Entities.System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fonour.IMS.EntityFrameworkCore
{
    public class IMSDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public virtual DbSet<Menu> Menus { get; set; }

        public IMSDbContext(DbContextOptions<IMSDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.AddEntityConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
}
