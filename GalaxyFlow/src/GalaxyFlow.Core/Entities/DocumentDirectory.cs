using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class DocumentDirectory : Entity<Guid>
    {
        public Guid ParentID { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }

        public string ReadUsers { get; set; }

        public string ManageUsers { get; set; }

        public string PublishUsers { get; set; }

        public int Sort { get; set; }
    }
}
