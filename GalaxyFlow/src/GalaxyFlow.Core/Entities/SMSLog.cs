using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class SMSLog : Entity<Guid>
    {
        public virtual string MobileNumber { get; set; }

        [MaxLength(200)]
        public virtual string Contents { get; set; }

        public virtual Guid? SendUserID { get; set; }

        [MaxLength(500)]
        public virtual string SendUserName { get; set; }

        public virtual DateTime SendTime { get; set; }

        public virtual int Status { get; set; }

        public virtual string Note { get; set; }
    }
}
