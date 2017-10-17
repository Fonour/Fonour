using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.EntityFrameworkCore.Mappings
{
    /// <summary>
    /// 实体映射配置接口
    /// </summary>
    public interface IEntityMappingConfiguration
    {
        void Map(ModelBuilder builder);
    }

    /// <summary>
    /// 实体映射配置泛型接口
    /// </summary>
    /// <typeparam name="T">实体类型</typeparam>
    public interface IEntityMappingConfiguration<T> : IEntityMappingConfiguration where T : class
    {
        void Map(EntityTypeBuilder<T> builder);
    }
}
