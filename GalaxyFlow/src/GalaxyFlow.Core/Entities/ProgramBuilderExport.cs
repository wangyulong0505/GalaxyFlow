using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilderExport : Entity<Guid>
    {
        public virtual Guid ProgramID { get; set; }

        [MaxLength(500)]
        public virtual string Field { get; set; }

        [MaxLength(500)]
        public virtual string ShowTitle { get; set; }

        public virtual int Align { get; set; }

        public virtual int? Width { get; set; }

        public virtual int? ShowType { get; set; }

        public virtual int? DataType { get; set; }

        [MaxLength(50)]
        public virtual string ShowFormat { get; set; }

        [MaxLength(5000)]
        public virtual string CustomString { get; set; }

        public virtual int Sort { get; set; }
    }
}
