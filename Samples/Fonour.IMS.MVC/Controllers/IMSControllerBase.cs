using Abp.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fonour.IMS.MVC.Controllers
{
    public class IMSControllerBase : AbpController
    {
        protected IMSControllerBase()
        {
            //LocalizationSourceName = IMSConsts.LocalizationSourceName;
        }
    }
}
