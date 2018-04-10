using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class TempTest_Purchase : Entity<Guid>
    {
        [MaxLength(500)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string UserID { get; set; }

        [MaxLength(50)]
        public string UserDept { get; set; }

        [MaxLength(50)]
        public string SqDateTime { get; set; }

        [MaxLength(500)]
        public string TypeOther { get; set; }

        [MaxLength(500)]
        public string Note { get; set; }

        public int IsCompleted { get; set; }
    }
}
