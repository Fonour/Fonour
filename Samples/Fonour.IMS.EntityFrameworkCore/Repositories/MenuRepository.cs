using Abp.EntityFrameworkCore;
using Fonour.IMS.Domain.Entities.System;
using Fonour.IMS.Domain.IRepositories.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fonour.IMS.EntityFrameworkCore.Repositories
{
    public class MenuRepository : IMSRepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbContextProvider<IMSDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
