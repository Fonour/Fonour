using Abp.AspNetCore;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Fonour.IMS.Application;
using Fonour.IMS.Domain;
using Fonour.IMS.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fonour.IMS.MVC
{
    [DependsOn(
    typeof(IMSApplicationModule),
    typeof(IMSEntityFrameworkCoreModule),
    typeof(AbpAspNetCoreModule))]
    public class IMSMVCModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public IMSMVCModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString("Default");

            //Configuration.Navigation.Providers.Add<IMSNavigationProvider>();

            //Configuration.Modules.AbpAspNetCore().CreateControllersForAppServices(typeof(IMSApplicationModule).GetAssembly());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IMSMVCModule).GetAssembly());
        }
    }
}
