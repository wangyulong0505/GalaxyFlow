using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class WorkFlowComment : Entity<Guid>
    {
        /// <summary>
        /// MemberID
        /// </summary>
        public string MemberID { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 类型 0管理员添加 1用户添加
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Sort
        /// </summary>
        public int Sort { get; set; }
    }
}
