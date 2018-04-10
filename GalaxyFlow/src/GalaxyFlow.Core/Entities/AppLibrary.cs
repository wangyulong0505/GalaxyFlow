using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class AppLibrary : Entity<Guid>
    {
        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        public Guid Type { get; set; }

        public int OpenMode { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public string Params { get; set; }

        public string Manager { get; set; }

        public string Note { get; set; }

        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(2000)]
        public string Ico { get; set; }

        [MaxLength(50)]
        public string Color { get; set; }
    }
}
