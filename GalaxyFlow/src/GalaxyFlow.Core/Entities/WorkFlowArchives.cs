using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class WorkFlowArchives : Entity<Guid>
    {
        /// <summary>
        /// 流程ID
        /// </summary>
        public virtual Guid FlowID { get; set; }

        /// <summary>
        /// 步骤ID
        /// </summary>
        public virtual Guid StepID { get; set; }

        /// <summary>
        /// FlowName
        /// </summary>
        /// 
        [MaxLength(500)]
        public virtual string FlowName { get; set; }

        /// <summary>
        /// StepName
        /// </summary>
        /// 
        [MaxLength(500)]
        public virtual string StepName { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        public virtual Guid TaskID { get; set; }

        /// <summary>
        /// 组
        /// </summary>
        public virtual Guid GroupID { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        /// 
        [MaxLength(500)]
        public virtual string InstanceID { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        /// 
        [MaxLength(4000)]
        public virtual string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public virtual string Contents { get; set; }

        /// <summary>
        /// 意见内容
        /// </summary>
        public virtual string Comments { get; set; }

        /// <summary>
        /// 写入时间
        /// </summary>
        public virtual DateTime WriteTime { get; set; }
    }
}
