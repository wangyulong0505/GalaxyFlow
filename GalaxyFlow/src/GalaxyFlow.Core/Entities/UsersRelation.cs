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
        public Guid OrganizeID { get; set; }

        /// <summary>
        /// IsMain
        /// </summary>
        public int IsMain { get; set; }

        /// <summary>
        /// Sort
        /// </summary>
        public int Sort { get; set; }
    }
}
