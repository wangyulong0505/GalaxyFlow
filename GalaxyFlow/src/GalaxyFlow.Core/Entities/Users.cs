using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class Users : Entity<Guid>
    {
        /// <summary>
        /// Name
        /// </summary>
        /// 
        [MaxLength(50)]
        public virtual string Name { get; set; }

        /// <summary>
        /// Account
        /// </summary>
        /// 
        [MaxLength(255)]
        public virtual string Account { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// 
        [MaxLength(500)]
        public virtual string Password { get; set; }

        /// <summary>
        /// 状态 0 正常 1 冻结
        /// </summary>
        public virtual int Status { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public virtual int Sort { get; set; }

        /// <summary>
        /// 系统备注
        /// </summary>
        public virtual string Note { get; set; }

        [MaxLength(50)]
        public virtual string Mobile { get; set; }

        [MaxLength(500)]
        public virtual string Tel { get; set; }

        [MaxLength(500)]
        public virtual string OtherTel { get; set; }

        [MaxLength(50)]
        public virtual string Fax { get; set; }

        [MaxLength(500)]
        public virtual string Email { get; set; }

        [MaxLength(50)]
        public virtual string QQ { get; set; }

        [MaxLength(500)]
        public virtual string HeadImg { get; set; }

        [MaxLength(50)]
        public virtual string WeiXin { get; set; }

        public virtual int? Sex { get; set; }
    }
}
