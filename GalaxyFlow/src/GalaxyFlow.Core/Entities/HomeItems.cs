using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class HomeItems : Entity<Guid>
    {
        public virtual int Type { get; set; }

        [MaxLength(500)]
        public virtual string Name { get; set; }

        [MaxLength(500)]
        public virtual string Title { get; set; }

        public virtual int DataSourceType { get; set; }

        public virtual string DataSource { get; set; }

        [MaxLength(2000)]
        public virtual string Ico { get; set; }

        [MaxLength(50)]
        public virtual string BgColor { get; set; }

        [MaxLength(50)]
        public virtual string Color { get; set; }

        public virtual Guid? DBConnID { get; set; }

        [MaxLength(2000)]
        public virtual string LinkURL { get; set; }

        public virtual string UseOrganizes { get; set; }

        public virtual string UseUsers { get; set; }

        public virtual int? Sort { get; set; }

        [MaxLength(2000)]
        public virtual string Note { get; set; }
    }
}
