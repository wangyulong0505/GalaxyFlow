using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class MenuUser : Entity<Guid>
    {
        public Guid MenuID { get; set; }

        public Guid SubPageID { get; set; }

        [MaxLength(100)]
        public string Organizes { get; set; }

        public string Users { get; set; }

        public string Buttons { get; set; }

        public string Params { get; set; }
    }
}
