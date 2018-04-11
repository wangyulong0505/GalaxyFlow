using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilder : Entity<Guid>
    {
        [MaxLength(500)]
        public virtual string Name { get; set; }

        public virtual Guid Type { get; set; }

        public virtual DateTime CreateTime { get; set; }

        public virtual DateTime? PublishTime { get; set; }

        public virtual Guid CreateUser { get; set; }

        public virtual string SQL { get; set; }

        public virtual string IsAdd { get; set; }

        public virtual Guid DBConnID { get; set; }

        public virtual int Status { get; set; }

        [MaxLength(500)]
        public virtual string FormID { get; set; }

        public virtual int? EditModel { get; set; }

        [MaxLength(50)]
        public virtual string Width { get; set; }

        [MaxLength(50)]
        public virtual string Height { get; set; }

        public virtual int? ButtonLocation { get; set; }

        public virtual int? IsPager { get; set; }

        public virtual string ClientScript { get; set; }

        [MaxLength(4000)]
        public virtual string ExportTemplate { get; set; }

        [MaxLength(500)]
        public virtual string ExportHeaderText { get; set; }

        [MaxLength(500)]
        public virtual string ExportFileName { get; set; }

        [MaxLength(255)]
        public virtual string TableStyle { get; set; }

        public virtual string TableHead { get; set; }

        [MaxLength(500)]
        public virtual string TableName { get; set; }

        [MaxLength(500)]
        public virtual string InDataNumberFiledName { get; set; }
    }
}
