using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class UsersRelation : Entity<Guid>
    {
        /// <summary>
        /// OrganizeID
        /// </summary>
        public virtual Guid OrganizeID { get; set; }

        /// <summary>
        /// IsMain
        /// </summary>
        public virtual int IsMain { get; set; }

        /// <summary>
        /// Sort
        /// </summary>
        public virtual int Sort { get; set; }
    }
}
