using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class TempTest_News : Entity
    {
        [MaxLength(500)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string Title1 { get; set; }

        [MaxLength(50)]
        public string UserID { get; set; }

        [MaxLength(500)]
        public string Type { get; set; }

        public string Contents { get; set; }

        public int State { get; set; }
    }
}
