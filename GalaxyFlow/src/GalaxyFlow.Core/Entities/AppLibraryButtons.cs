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
        public string Name { get; set; }

        [MaxLength(5000)]
        public string Events { get; set; }

        [MaxLength(5000)]
        public string Ico { get; set; }

        public int Sort { get; set; }

        [MaxLength(500)]
        public string Note { get; set; }
    }
}
