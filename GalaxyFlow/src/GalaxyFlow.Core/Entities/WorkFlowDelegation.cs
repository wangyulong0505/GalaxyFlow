using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class WorkFlowDelegation : Entity<Guid>
    {
        /// <summary>
        /// 委托人
        /// </summary>
        public virtual Guid UserID { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public virtual DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public virtual DateTime EndTime { get; set; }

        /// <summary>
        /// 委托流程ID,为空表示所有流程
        /// </summary>
        public virtual Guid? FlowID { get; set; }

        /// <summary>
        /// 被委托人
        /// </summary>
        public virtual Guid ToUserID { get; set; }

        /// <summary>
        /// 设置时间
        /// </summary>
        public virtual DateTime WriteTime { get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        /// 
        [MaxLength(4000)]
        public virtual string Note { get; set; }

    }
}
