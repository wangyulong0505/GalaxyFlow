using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class Organize : Entity<Guid>
    {
        [MaxLength(2000)]
        public string Name { get; set; }

        [MaxLength(900)]
        public string Number { get; set; }

        public int Type { get; set; }

        public int Status { get; set; }

        public Guid ParentID { get; set; }

        public int Sort { get; set; }

        public int Depth { get; set; }

        public int ChildsLength { get; set; }

        [MaxLength(200)]
        public string ChargeLeader { get; set; }

        [MaxLength(200)]
        public string Leader { get; set; }

        public string Note { get; set; }

        public int IntID { get; set; }
    }
}
