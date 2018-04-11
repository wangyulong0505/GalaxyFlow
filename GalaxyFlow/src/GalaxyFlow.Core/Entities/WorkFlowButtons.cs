using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class WorkFlowButtons : Entity<Guid>
    {
        /// <summary>
        /// 标题
        /// </summary>
        /// 
        [MaxLength(500)]
        public virtual string Title { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        /// 
        [MaxLength(500)]
        public virtual string Ico { get; set; }

        /// <summary>
        /// 脚本
        /// </summary>
        public virtual string Script { get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        public virtual string Note { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public virtual int Sort { get; set; }
    }
}
