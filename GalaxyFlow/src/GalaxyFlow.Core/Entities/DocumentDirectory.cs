using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class DocumentDirectory : Entity<Guid>
    {
        public virtual Guid ParentID { get; set; }

        [MaxLength(500)]
        public virtual string Name { get; set; }

        public virtual string ReadUsers { get; set; }

        public virtual string ManageUsers { get; set; }

        public virtual string PublishUsers { get; set; }

        public virtual int Sort { get; set; }
    }
}
