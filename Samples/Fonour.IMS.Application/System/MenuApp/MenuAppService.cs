using System;
using System.Collections.Generic;
using System.Text;
using Fonour.IMS.Domain.Entities.System;
using Abp.Domain.Repositories;

namespace Fonour.IMS.Application.System.MenuApp
{
    public class MenuAppService : IMenuAppService
    {
        private readonly IRepository<Menu> _repository;

        public MenuAppService(IRepository<Menu> repository)
        {
            _repository = repository;
        }
        public List<Menu> GetAll()
        {
            return _repository.GetAllList();
        }
    }
}
