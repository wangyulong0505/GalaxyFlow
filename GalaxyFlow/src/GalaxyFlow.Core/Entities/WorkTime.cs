using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class WorkTime : Entity<Guid>
    {
        public virtual int Year { get; set; }

        public virtual DateTime Date1 { get; set; }

        public virtual DateTime Date2 { get; set; }

        [MaxLength(50)]
        public virtual string AmTime1 { get; set; }

        [MaxLength(50)]
        public virtual string AmTime2 { get; set; }

        [MaxLength(50)]
        public virtual string PmTime1 { get; set; }

        [MaxLength(50)]
        public virtual string PmTime2 { get; set; }
    }
}
