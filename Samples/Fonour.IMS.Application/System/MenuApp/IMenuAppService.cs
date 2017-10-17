using Abp.Application.Services;
using Fonour.IMS.Domain.Entities.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fonour.IMS.Application.System.MenuApp
{
    public interface IMenuAppService : IApplicationService
    {
        List<Menu> GetAll();
    }
}
