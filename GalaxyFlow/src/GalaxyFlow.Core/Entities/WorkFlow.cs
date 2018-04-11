using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class WorkFlow : Entity<Guid>
    {
        /// <summary>
        /// 流程名称
        /// </summary>
        /// 
        [MaxLength(500)]
        public virtual string Name { get; set; }

        /// <summary>
        /// 流程分类
        /// </summary>
        public virtual Guid Type { get; set; }

        /// <summary>
        /// 管理人员
        /// </summary>
        /// 
        [MaxLength(5000)]
        public virtual string Manager { get; set; }

        /// <summary>
        /// 实例管理人员
        /// </summary>
        /// 
        [MaxLength(5000)]
        public virtual string InstanceManager { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public virtual DateTime CreateDate { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public virtual Guid CreateUserID { get; set; }

        /// <summary>
        /// 设计时
        /// </summary>
        public virtual string DesignJSON { get; set; }

        /// <summary>
        /// 安装日期
        /// </summary>
        public virtual DateTime? InstallDate { get; set; }

        /// <summary>
        /// 安装人员
        /// </summary>
        public virtual Guid? InstallUserID { get; set; }

        /// <summary>
        /// 运行时
        /// </summary>
        public virtual string RunJSON { get; set; }

        /// <summary>
        /// 状态 1:设计中 2:已安装 3:已卸载 4:已删除
        /// </summary>
        public virtual int Status { get; set; }
    }
}
