using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class ProgramBuilderButtons : Entity<Guid>
    {
        public Guid ProgramID { get; set; }

        public Guid ButtonID { get; set; }

        [MaxLength(200)]
        public string ButtonName { get; set; }

        public string ClientScript { get; set; }

        [MaxLength(200)]
        public string Ico { get; set; }

        public int ShowType { get; set; }

        public int Sort { get; set; }

        public int IsValidateShow { get; set; }
    }
}
