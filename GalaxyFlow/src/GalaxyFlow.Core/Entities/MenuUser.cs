using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class MenuUser : Entity<Guid>
    {
        public virtual Guid MenuID { get; set; }

        public virtual Guid SubPageID { get; set; }

        [MaxLength(100)]
        public virtual string Organizes { get; set; }

        public virtual string Users { get; set; }

        public virtual string Buttons { get; set; }

        public virtual string Params { get; set; }
    }
}
