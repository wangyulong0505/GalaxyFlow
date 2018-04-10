using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyFlow.Entities
{
    public class WorkFlow : Entity<Guid>
    {
        /// <summary>
        /// 流程名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 流程分类
        /// </summary>
        public Guid Type { get; set; }

        /// <summary>
        /// 管理人员
        /// </summary>
        public string Manager { get; set; }

        /// <summary>
        /// 实例管理人员
        /// </summary>
        public string InstanceManager { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public Guid CreateUserID { get; set; }

        /// <summary>
        /// 设计时
        /// </summary>
        public string DesignJSON { get; set; }

        /// <summary>
        /// 安装日期
        /// </summary>
        public DateTime? InstallDate { get; set; }

        /// <summary>
        /// 安装人员
        /// </summary>
        public Guid? InstallUserID { get; set; }

        /// <summary>
        /// 运行时
        /// </summary>
        public string RunJSON { get; set; }

        /// <summary>
        /// 状态 1:设计中 2:已安装 3:已卸载 4:已删除
        /// </summary>
        public int Status { get; set; }
    }
}
