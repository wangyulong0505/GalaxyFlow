using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilderButtons : Entity<Guid>
    {
        public virtual Guid ProgramID { get; set; }

        public virtual Guid? ButtonID { get; set; }

        [MaxLength(200)]
        public virtual string ButtonName { get; set; }

        public virtual string ClientScript { get; set; }

        [MaxLength(200)]
        public virtual string Ico { get; set; }

        public virtual int ShowType { get; set; }

        public virtual int Sort { get; set; }

        public virtual int IsValidateShow { get; set; }
    }
}
