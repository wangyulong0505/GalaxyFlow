using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilder : Entity<Guid>
    {
        [MaxLength(500)]
        public string Name { get; set; }

        public Guid Type { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime PublishTime { get; set; }

        public Guid CreateUser { get; set; }

        public string SQL { get; set; }

        public string IsAdd { get; set; }

        public Guid DBConnID { get; set; }

        public int Status { get; set; }

        [MaxLength(500)]
        public string FormID { get; set; }

        public int EditModel { get; set; }

        [MaxLength(50)]
        public string Width { get; set; }

        [MaxLength(50)]
        public string Height { get; set; }

        public int ButtonLocation { get; set; }

        public int IsPager { get; set; }

        public string ClientScript { get; set; }

        [MaxLength(4000)]
        public string ExportTemplate { get; set; }

        [MaxLength(500)]
        public string ExportHeaderText { get; set; }

        [MaxLength(500)]
        public string ExportFileName { get; set; }

        [MaxLength(255)]
        public string TableStyle { get; set; }

        public string TableHead { get; set; }

        [MaxLength(500)]
        public string TableName { get; set; }

        [MaxLength(500)]
        public string InDataNumberFiledName { get; set; }
    }
}
