using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class WorkFlowComment : Entity<Guid>
    {
        /// <summary>
        /// MemberID
        /// </summary>
        public virtual string MemberID { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        /// 
        [MaxLength(500)]
        public virtual string Comment { get; set; }

        /// <summary>
        /// 类型 0管理员添加 1用户添加
        /// </summary>
        public virtual int Type { get; set; }

        /// <summary>
        /// Sort
        /// </summary>
        public virtual int Sort { get; set; }
    }
}
