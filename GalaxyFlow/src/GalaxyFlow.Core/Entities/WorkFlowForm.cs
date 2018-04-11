using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class WorkFlowForm : Entity<Guid>
    {
        /// <summary>
        /// 表单名称
        /// </summary>
        /// 
        [MaxLength(500)]
        public virtual string Name { get; set; }

        /// <summary>
        /// 表单分类
        /// </summary>
        public virtual Guid Type { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public virtual Guid CreateUserID { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        /// 
        [MaxLength(50)]
        public virtual string CreateUserName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public virtual DateTime LastModifyTime { get; set; }

        /// <summary>
        /// 表单html
        /// </summary>
        public virtual string Html { get; set; }

        /// <summary>
        /// 从表设置数据
        /// </summary>
        public virtual string SubTableJson { get; set; }

        /// <summary>
        /// 事件设置
        /// </summary>
        public virtual string EventsJson { get; set; }

        /// <summary>
        /// 相关属性
        /// </summary>
        public virtual string Attribute { get; set; }

        /// <summary>
        /// 状态：0 保存 1 编译 2作废
        /// </summary>
        public virtual int Status { get; set; }

    }
}
