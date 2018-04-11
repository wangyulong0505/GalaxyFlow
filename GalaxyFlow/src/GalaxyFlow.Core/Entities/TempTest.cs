using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class TempTest : Entity<Guid>
    {
        [MaxLength(500)]
        public virtual string Title { get; set; }

        [MaxLength(50)]
        public virtual string UserID { get; set; }

        [MaxLength(50)]
        public virtual string UserID_text { get; set; }

        [MaxLength(50)]
        public virtual string DeptID { get; set; }

        [MaxLength(500)]
        public virtual string DeptName { get; set; }

        public virtual DateTime? Date1 { get; set; }

        public virtual DateTime? Date2 { get; set; }

        [MaxLength(500)]
        public virtual string Type { get; set; }

        [MaxLength(50)]
        public virtual string Reason { get; set; }

        public virtual DateTime? WriteTime { get; set; }

        public virtual float? Days { get; set; }

        [MaxLength(5000)]
        public virtual string test { get; set; }

        [MaxLength(5000)]
        public virtual string test1 { get; set; }

        [MaxLength(5000)]
        public virtual string test2 { get; set; }

        [MaxLength(5000)]
        public virtual string test2_text { get; set; }
    }
}
