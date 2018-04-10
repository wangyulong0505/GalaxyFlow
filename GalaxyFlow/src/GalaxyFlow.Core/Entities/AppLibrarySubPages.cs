using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class AppLibrarySubPages : Entity<Guid>
    {
        public Guid AppLibraryID { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }

        [MaxLength(5000)]
        public string Address { get; set; }

        [MaxLength(5000)]
        public string Ico { get; set; }

        public int Sort { get; set; }

        [MaxLength(2000)]
        public string Note { get; set; }
    }
}
