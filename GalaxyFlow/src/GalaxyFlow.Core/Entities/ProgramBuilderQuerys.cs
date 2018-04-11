using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilderQuerys : Entity<Guid>
    {
        public virtual Guid ProgramID { get; set; }

        [MaxLength(500)]
        public virtual string Field { get; set; }

        [MaxLength(500)]
        public virtual string ShowTitle { get; set; }

        [MaxLength(50)]
        public virtual string Operators { get; set; }

        [MaxLength(50)]
        public virtual string ControlName { get; set; }

        public virtual int InputType { get; set; }

        [MaxLength(50)]
        public virtual string Width { get; set; }

        public virtual int Sort { get; set; }

        public virtual int? DataSource { get; set; }

        public virtual string DataSourceString { get; set; }

        [MaxLength(50)]
        public virtual string DataLinkID { get; set; }

        public virtual int? IsQueryUsers { get; set; }

        [MaxLength(50)]
        public virtual string Value { get; set; }
    }
}
