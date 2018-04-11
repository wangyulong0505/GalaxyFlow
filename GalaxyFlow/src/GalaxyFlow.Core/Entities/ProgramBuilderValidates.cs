using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilderValidates : Entity<Guid>
    {
        public virtual Guid ProgramID { get; set; }

        [MaxLength(500)]
        public virtual string TableName { get; set; }

        [MaxLength(500)]
        public virtual string FieldName { get; set; }

        [MaxLength(500)]
        public virtual string FieldNote { get; set; }

        public virtual int Validate { get; set; }
    }
}
