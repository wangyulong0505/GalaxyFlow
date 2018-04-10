using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class Menu : Entity<Guid>
    {
        public Guid ParentID { get; set; }

        public Guid AppLibraryID { get; set; }

        [MaxLength(500)]
        public string Title { get; set; }

        [MaxLength(5000)]
        public string Params { get; set; }

        [MaxLength(500)]
        public string Ico { get; set; }

        public int Sort { get; set; }

        [MaxLength(50)]
        public string IcoColor { get; set; }
    }
}
