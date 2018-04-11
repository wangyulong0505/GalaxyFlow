using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class WorkCalendar : Entity<DateTime>
    {
        public DateTime WorkDate { get => base.Id; set => base.Id = value; }
    }
}
