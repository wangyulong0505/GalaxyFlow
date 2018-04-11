using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class Dictionary : Entity<Guid>
    {
        public virtual Guid ParentID { get; set; }

        public virtual string Title { get; set; }

        [MaxLength(500)]
        public virtual string Code { get; set; }

        public virtual string Value { get; set; }

        public virtual string Note { get; set; }

        public virtual string Other { get; set; }

        public virtual int Sort { get; set; }
    }
}
