using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class UserShortcut : Entity<Guid>
    {
        public Guid MenuID { get; set; }

        public Guid UserID { get; set; }

        public int Sort { get; set; }
    }
}
