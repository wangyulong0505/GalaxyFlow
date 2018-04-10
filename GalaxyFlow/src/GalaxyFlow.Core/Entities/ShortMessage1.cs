using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ShortMessage1 : Entity<Guid>
    {
        [MaxLength(500)]
        public string Title { get; set; }

        public string Contents { get; set; }

        public Guid SendUserID { get; set; }

        [MaxLength(500)]
        public string SendUserName { get; set; }

        public Guid ReceiveUserID { get; set; }

        [MaxLength(500)]
        public string ReceiveUserName { get; set; }

        public DateTime SendTime { get; set; }

        public string LinkUrl { get; set; }

        [MaxLength(50)]
        public string LinkID { get; set; }

        public int Type { get; set; }

        public string Files { get; set; }
    }
}
