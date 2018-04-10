using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilderFields : Entity<Guid>
    {
        public Guid ProgramID { get; set; }

        [MaxLength(500)]
        public string Field { get; set; }

        public int ShowTitle { get; set; }

        [MaxLength(50)]
        public string Align { get; set; }

        [MaxLength(50)]
        public string Width { get; set; }

        public string ShowType { get; set; }

        [MaxLength(50)]
        public string ShowFormat { get; set; }

        public string CustomString { get; set; }

        public int Sort { get; set; }
    }
}
