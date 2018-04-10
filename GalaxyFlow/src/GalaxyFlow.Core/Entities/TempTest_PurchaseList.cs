using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class TempTest_PurchaseList : Entity<Guid>
    {
        public Guid PurchaseID { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Model { get; set; }

        [MaxLength(50)]
        public string Unit { get; set; }

        public int Quantity { get; set; }

        public decimal Sum1 { get; set; }

        public DateTime Date { get; set; }

        [MaxLength(500)]
        public string Type { get; set; }

        [MaxLength(500)]
        public string Note { get; set; }
    }
}
