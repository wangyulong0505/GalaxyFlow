using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class Organize : Entity<Guid>
    {
        [MaxLength(2000)]
        public virtual string Name { get; set; }

        [MaxLength(900)]
        public virtual string Number { get; set; }

        public virtual int Type { get; set; }

        public virtual int Status { get; set; }

        public virtual Guid ParentID { get; set; }

        public virtual int Sort { get; set; }

        public virtual int Depth { get; set; }

        public virtual int ChildsLength { get; set; }

        [MaxLength(200)]
        public virtual string ChargeLeader { get; set; }

        [MaxLength(200)]
        public virtual string Leader { get; set; }

        public virtual string Note { get; set; }

        public virtual int IntID { get; set; }
    }
}
