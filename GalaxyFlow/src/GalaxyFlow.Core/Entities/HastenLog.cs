using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class HastenLog : Entity<Guid>
    {
        [MaxLength(5000)]
        public virtual string OthersParams { get; set; }

        [MaxLength(5000)]
        public virtual string Users { get; set; }

        [MaxLength(500)]
        public virtual string Types { get; set; }

        [MaxLength(500)]
        public virtual string Contents { get; set; }

        public virtual Guid SendUser { get; set; }

        [MaxLength(50)]
        public virtual string SendUserName { get; set; }

        public virtual DateTime SendTime { get; set; }
    }
}
