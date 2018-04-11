using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class DbConnection : Entity<Guid>
    {
        [MaxLength(500)]
        public virtual string Name { get; set; }

        [MaxLength(500)]
        public virtual string Type { get; set; }

        public virtual string ConnectionString { get; set; }

        public virtual string Note { get; set; }
    }
}
