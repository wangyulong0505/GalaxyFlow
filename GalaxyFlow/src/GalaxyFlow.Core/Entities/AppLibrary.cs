using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class AppLibrary : Entity<Guid>
    {
        [MaxLength(255)]
        public virtual string Title { get; set; }

        [MaxLength(200)]
        public virtual string Address { get; set; }

        public virtual Guid Type { get; set; }

        public virtual int OpenMode { get; set; }

        public virtual int? Width { get; set; }

        public virtual int? Height { get; set; }

        public virtual string Params { get; set; }

        public virtual string Manager { get; set; }

        public virtual string Note { get; set; }

        [MaxLength(50)]
        public virtual string Code { get; set; }

        [MaxLength(2000)]
        public virtual string Ico { get; set; }

        [MaxLength(50)]
        public virtual string Color { get; set; }
    }
}
