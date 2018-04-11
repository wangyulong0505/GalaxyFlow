using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class AppLibraryButtons1 : Entity<Guid>
    {
        public virtual Guid AppLibraryID { get; set; }

        public virtual Guid? ButtonID { get; set; }

        [MaxLength(500)]
        public virtual string Name { get; set; }

        [MaxLength(5000)]
        public virtual string Events { get; set; }

        [MaxLength(2000)]
        public virtual string Ico { get; set; }

        public virtual int Sort { get; set; }

        public virtual int Type { get; set; }

        public virtual int ShowType { get; set; }

        public virtual int IsValidateShow { get; set; }
    }
}
