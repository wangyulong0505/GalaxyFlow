﻿using System;
using System.Collections.Generic;
using System.Text;
using GalaxyFlow.Entities;
using Abp.Domain.Repositories;

namespace GalaxyFlow.IRepositories
{
    public interface IWorkGroupRepository : IRepository<WorkGroup, Guid>
    {
    }
}
