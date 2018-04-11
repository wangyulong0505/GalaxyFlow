using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class Menu : Entity<Guid>
    {
        public virtual Guid ParentID { get; set; }

        public virtual Guid? AppLibraryID { get; set; }

        [MaxLength(500)]
        public virtual string Title { get; set; }

        [MaxLength(5000)]
        public virtual string Params { get; set; }

        [MaxLength(500)]
        public virtual string Ico { get; set; }

        public virtual int Sort { get; set; }

        [MaxLength(50)]
        public virtual string IcoColor { get; set; }
    }
}
