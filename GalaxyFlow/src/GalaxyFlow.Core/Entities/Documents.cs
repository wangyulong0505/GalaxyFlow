using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class Documents : Entity<Guid>
    {
        public virtual Guid DirectoryID { get; set; }

        [MaxLength(200)]
        public virtual string DirectoryName { get; set; }

        [MaxLength(300)]
        public virtual string Title { get; set; }

        [MaxLength(50)]
        public virtual string Source { get; set; }

        public virtual string Contents { get; set; }

        public virtual string Files { get; set; }

        public virtual DateTime WriteTime { get; set; }

        public virtual Guid WriteUserID { get; set; }

        [MaxLength(50)]
        public virtual string WriteUserName { get; set; }

        public virtual DateTime? EditTime { get; set; }

        public virtual Guid? EditUserID { get; set; }

        [MaxLength(50)]
        public virtual string EditUserName { get; set; }

        public virtual string ReadUsers { get; set; }

        public virtual int ReadCount { get; set; }
    }
}
