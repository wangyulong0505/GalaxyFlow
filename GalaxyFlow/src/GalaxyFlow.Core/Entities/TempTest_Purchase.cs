using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class TempTest_Purchase : Entity<Guid>
    {
        [MaxLength(500)]
        public virtual string Title { get; set; }

        [MaxLength(50)]
        public virtual string UserID { get; set; }

        [MaxLength(50)]
        public virtual string UserDept { get; set; }

        [MaxLength(50)]
        public virtual string SqDateTime { get; set; }

        [MaxLength(500)]
        public virtual string TypeOther { get; set; }

        [MaxLength(500)]
        public virtual string Note { get; set; }

        public virtual int? IsCompleted { get; set; }
    }
}
