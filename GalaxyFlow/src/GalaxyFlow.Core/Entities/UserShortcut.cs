using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class UserShortcut : Entity<Guid>
    {
        public virtual Guid MenuID { get; set; }

        public virtual Guid UserID { get; set; }

        public virtual int Sort { get; set; }
    }
}
