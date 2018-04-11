using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class AppLibraryButtons : Entity<Guid>
    {
        [MaxLength(50)]
        public virtual string Name { get; set; }

        [MaxLength(5000)]
        public virtual string Events { get; set; }

        [MaxLength(5000)]
        public virtual string Ico { get; set; }

        public virtual int Sort { get; set; }

        [MaxLength(500)]
        public virtual string Note { get; set; }
    }
}
