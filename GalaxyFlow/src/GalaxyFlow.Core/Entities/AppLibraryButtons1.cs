using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class AppLibraryButtons1 : Entity<Guid>
    {
        public Guid AppLibraryID { get; set; }

        public Guid ButtonID { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }

        [MaxLength(5000)]
        public string Events { get; set; }

        [MaxLength(2000)]
        public string Ico { get; set; }

        public int Sort { get; set; }

        public int Type { get; set; }

        public int ShowType { get; set; }

        public int IsValidateShow { get; set; }
    }
}
