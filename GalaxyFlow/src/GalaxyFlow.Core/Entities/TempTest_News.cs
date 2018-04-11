using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class TempTest_News : Entity
    {
        [MaxLength(500)]
        public virtual string Title { get; set; }

        [MaxLength(50)]
        public virtual string Title1 { get; set; }

        [MaxLength(50)]
        public virtual string UserID { get; set; }

        [MaxLength(500)]
        public virtual string Type { get; set; }

        public virtual string Contents { get; set; }

        public virtual int State { get; set; }
    }
}
