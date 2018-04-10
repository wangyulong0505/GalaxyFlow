using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class TempTest : Entity<Guid>
    {
        [MaxLength(500)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string UserID { get; set; }

        [MaxLength(50)]
        public string UserID_text { get; set; }

        [MaxLength(50)]
        public string DeptID { get; set; }

        [MaxLength(500)]
        public string DeptName { get; set; }

        public DateTime Date1 { get; set; }

        public DateTime Date2 { get; set; }

        [MaxLength(500)]
        public string Type { get; set; }

        [MaxLength(50)]
        public string Reason { get; set; }

        public DateTime WriteTime { get; set; }

        public float Days { get; set; }

        [MaxLength(5000)]
        public string test { get; set; }

        [MaxLength(5000)]
        public string test1 { get; set; }

        [MaxLength(5000)]
        public string test2 { get; set; }

        [MaxLength(5000)]
        public string test2_text { get; set; }
    }
}
