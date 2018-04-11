using Abp.Domain.Repositories;
using GalaxyFlow.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyFlow.IRepositories
{
    public interface ISMSLogRepository : IRepository<SMSLog, Guid>
    {
    }
}
