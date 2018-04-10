using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class DbConnection : Entity<Guid>
    {
        [MaxLength(500)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Type { get; set; }

        public string ConnectionString { get; set; }

        public string Note { get; set; }
    }
}
