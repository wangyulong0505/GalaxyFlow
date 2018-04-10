using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class Log : Entity<Guid>
    {
        public string Title { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }

        public DateTime WriteTime { get; set; }

        public Guid UserID { get; set; }

        [MaxLength(50)]
        public string UserName { get; set; }

        [MaxLength(50)]
        public string IPAddress { get; set; }

        public string URL { get; set; }

        public string Contents { get; set; }

        public string Others { get; set; }

        public string OldXml { get; set; }

        public string NewXml { get; set; }
    }
}
