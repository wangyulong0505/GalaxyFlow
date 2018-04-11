using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class TempTest_PurchaseList : Entity<Guid>
    {
        public virtual Guid PurchaseID { get; set; }

        [MaxLength(500)]
        public virtual string Name { get; set; }

        [MaxLength(50)]
        public virtual string Model { get; set; }

        [MaxLength(50)]
        public virtual string Unit { get; set; }

        public virtual int? Quantity { get; set; }

        public virtual decimal? Sum1 { get; set; }

        public virtual DateTime? Date { get; set; }

        [MaxLength(500)]
        public virtual string Type { get; set; }

        [MaxLength(500)]
        public virtual string Note { get; set; }
    }
}
