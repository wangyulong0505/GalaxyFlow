using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilderQuerys : Entity<Guid>
    {
        public Guid ProgramID { get; set; }

        [MaxLength(500)]
        public string Field { get; set; }

        [MaxLength(500)]
        public string ShowTitle { get; set; }

        [MaxLength(50)]
        public string Operators { get; set; }

        [MaxLength(50)]
        public string ControlName { get; set; }

        public int InputType { get; set; }

        [MaxLength(50)]
        public string Width { get; set; }

        public int Sort { get; set; }

        public int DataSource { get; set; }

        public string DataSourceString { get; set; }

        [MaxLength(50)]
        public string DataLinkID { get; set; }

        public int IsQueryUsers { get; set; }

        [MaxLength(50)]
        public string Value { get; set; }
    }
}
