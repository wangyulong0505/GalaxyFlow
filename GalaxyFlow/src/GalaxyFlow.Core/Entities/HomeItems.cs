using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class HomeItems : Entity<Guid>
    {
        public int Type { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Title { get; set; }

        public int DataSourceType { get; set; }

        public string DataSource { get; set; }

        [MaxLength(2000)]
        public string Ico { get; set; }

        [MaxLength(50)]
        public string BgColor { get; set; }

        [MaxLength(50)]
        public string Color { get; set; }

        public Guid DBConnID { get; set; }

        [MaxLength(2000)]
        public string LinkURL { get; set; }

        public string UseOrganizes { get; set; }

        public string UseUsers { get; set; }

        public int Sort { get; set; }

        [MaxLength(2000)]
        public string Note { get; set; }
    }
}
