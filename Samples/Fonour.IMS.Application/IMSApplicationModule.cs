using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Fonour.IMS.Domain;
using System;

namespace Fonour.IMS.Application
{
    [DependsOn(typeof(IMSDomainModule),typeof(AbpAutoMapperModule))]
    public class IMSApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IMSApplicationModule).GetAssembly());
        }
    }
}
