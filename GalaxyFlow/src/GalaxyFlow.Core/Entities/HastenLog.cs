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
        public string OthersParams { get; set; }

        [MaxLength(5000)]
        public string Users { get; set; }

        [MaxLength(500)]
        public string Types { get; set; }

        [MaxLength(500)]
        public string Contents { get; set; }

        public Guid SendUser { get; set; }

        [MaxLength(50)]
        public string SendUserName { get; set; }

        public DateTime SendTime { get; set; }
    }
}
