using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class WorkFlowDelegation : Entity<Guid>
    {
        /// <summary>
        /// 委托人
        /// </summary>
        public Guid UserID { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 委托流程ID,为空表示所有流程
        /// </summary>
        public Guid? FlowID { get; set; }

        /// <summary>
        /// 被委托人
        /// </summary>
        public Guid ToUserID { get; set; }

        /// <summary>
        /// 设置时间
        /// </summary>
        public DateTime WriteTime { get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        public string Note { get; set; }

    }
}
