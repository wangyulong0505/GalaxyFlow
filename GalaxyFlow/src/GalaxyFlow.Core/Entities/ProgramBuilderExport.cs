using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilderExport : Entity<Guid>
    {
        public Guid ProgramID { get; set; }

        [MaxLength(500)]
        public string Field { get; set; }

        [MaxLength(500)]
        public string ShowTitle { get; set; }

        public int Align { get; set; }

        public int Width { get; set; }

        public int ShowType { get; set; }

        public int DataType { get; set; }

        [MaxLength(50)]
        public string ShowFormat { get; set; }

        [MaxLength(5000)]
        public string CustomString { get; set; }

        public int Sort { get; set; }
    }
}
