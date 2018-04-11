using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ShortMessage1 : Entity<Guid>
    {
        [MaxLength(500)]
        public virtual string Title { get; set; }

        public virtual string Contents { get; set; }

        public virtual Guid SendUserID { get; set; }

        [MaxLength(500)]
        public virtual string SendUserName { get; set; }

        public virtual Guid ReceiveUserID { get; set; }

        [MaxLength(500)]
        public virtual string ReceiveUserName { get; set; }

        public virtual DateTime SendTime { get; set; }

        public virtual string LinkUrl { get; set; }

        [MaxLength(50)]
        public virtual string LinkID { get; set; }

        public virtual int Type { get; set; }

        public virtual string Files { get; set; }
    }
}
