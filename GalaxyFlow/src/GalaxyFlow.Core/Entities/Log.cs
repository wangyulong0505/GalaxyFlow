using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class Log : Entity<Guid>
    {
        public virtual string Title { get; set; }

        [MaxLength(50)]
        public virtual string Type { get; set; }

        public virtual DateTime WriteTime { get; set; }

        public virtual Guid? UserID { get; set; }

        [MaxLength(50)]
        public virtual string UserName { get; set; }

        [MaxLength(50)]
        public virtual string IPAddress { get; set; }

        public virtual string URL { get; set; }

        public virtual string Contents { get; set; }

        public virtual string Others { get; set; }

        public virtual string OldXml { get; set; }

        public virtual string NewXml { get; set; }
    }
}
