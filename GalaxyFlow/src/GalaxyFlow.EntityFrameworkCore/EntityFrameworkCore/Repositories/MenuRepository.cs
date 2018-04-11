﻿using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class MenuRepository : GalaxyFlowRepositoryBase<Menu, Guid>, IMenuRepository
    {
        public MenuRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
