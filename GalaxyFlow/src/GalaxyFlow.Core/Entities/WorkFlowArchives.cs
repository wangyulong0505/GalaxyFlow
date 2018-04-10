using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class WorkFlowArchives : Entity<Guid>
    {
        /// <summary>
        /// 流程ID
        /// </summary>
        public Guid FlowID { get; set; }

        /// <summary>
        /// 步骤ID
        /// </summary>
        public Guid StepID { get; set; }

        /// <summary>
        /// FlowName
        /// </summary>
        public string FlowName { get; set; }

        /// <summary>
        /// StepName
        /// </summary>
        public string StepName { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        public Guid TaskID { get; set; }

        /// <summary>
        /// 组
        /// </summary>
        public Guid GroupID { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        public string InstanceID { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Contents { get; set; }

        /// <summary>
        /// 意见内容
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// 写入时间
        /// </summary>
        public DateTime WriteTime { get; set; }
    }
}
