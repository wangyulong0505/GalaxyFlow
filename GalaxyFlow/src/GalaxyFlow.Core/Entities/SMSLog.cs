using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class SMSLog : Entity<Guid>
    {
        public string MobileNumber { get; set; }

        [MaxLength(200)]
        public string Contents { get; set; }

        public Guid SendUserID { get; set; }

        [MaxLength(500)]
        public string SendUserName { get; set; }

        public DateTime SendTime { get; set; }

        public int Status { get; set; }

        public string Note { get; set; }
    }
}
