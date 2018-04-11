using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilderFields : Entity<Guid>
    {
        public virtual Guid ProgramID { get; set; }

        [MaxLength(500)]
        public virtual string Field { get; set; }

        public virtual int ShowTitle { get; set; }

        [MaxLength(50)]
        public virtual string Align { get; set; }

        [MaxLength(50)]
        public virtual string Width { get; set; }

        public virtual string ShowType { get; set; }

        [MaxLength(50)]
        public virtual string ShowFormat { get; set; }

        public virtual string CustomString { get; set; }

        public virtual int Sort { get; set; }
    }
}
