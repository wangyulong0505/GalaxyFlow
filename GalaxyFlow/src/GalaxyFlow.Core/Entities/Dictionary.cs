using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class Dictionary : Entity<Guid>
    {
        public Guid ParentID { get; set; }

        public string Title { get; set; }

        [MaxLength(500)]
        public string Code { get; set; }

        public string Value { get; set; }

        public string Note { get; set; }

        public string Other { get; set; }

        public int Sort { get; set; }
    }
}
