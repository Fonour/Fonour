using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Fonour.IMS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fonour.IMS.EntityFrameworkCore
{
    [DependsOn(typeof(IMSDomainModule),typeof(AbpEntityFrameworkCoreModule))]
    public class IMSEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IMSEntityFrameworkCoreModule).GetAssembly());
        }
    }
}
