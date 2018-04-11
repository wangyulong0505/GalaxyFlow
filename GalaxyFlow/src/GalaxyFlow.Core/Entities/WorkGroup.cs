using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class WorkGroup : Entity<Guid>
    {
        [MaxLength(500)]
        public virtual string Name { get; set; }

        public virtual string Members { get; set; }

        public virtual string Note { get; set; }

        public virtual string IntID { get; set; }
    }
}
