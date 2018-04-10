using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilderValidates : Entity<Guid>
    {
        public Guid ProgramID { get; set; }

        [MaxLength(500)]
        public string TableName { get; set; }

        [MaxLength(500)]
        public string FieldName { get; set; }

        [MaxLength(500)]
        public string FieldNote { get; set; }

        public int Validate { get; set; }
    }
}
