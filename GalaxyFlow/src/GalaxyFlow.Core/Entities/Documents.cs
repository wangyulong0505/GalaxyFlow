using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class Documents : Entity<Guid>
    {
        public Guid DirectoryID { get; set; }

        [MaxLength(200)]
        public string DirectoryName { get; set; }

        [MaxLength(300)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string Source { get; set; }

        public string Contents { get; set; }

        public string Files { get; set; }

        public DateTime WriteTime { get; set; }

        public Guid WriteUserID { get; set; }

        [MaxLength(50)]
        public string WriteUserName { get; set; }

        public DateTime EditTime { get; set; }

        public Guid EditUserID { get; set; }

        [MaxLength(50)]
        public string EditUserName { get; set; }

        public string ReadUsers { get; set; }

        public int ReadCount { get; set; }
    }
}
