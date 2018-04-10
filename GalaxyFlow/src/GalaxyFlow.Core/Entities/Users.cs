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
        public string Name { get; set; }

        /// <summary>
        /// Account
        /// </summary>
        /// 
        [MaxLength(255)]
        public string Account { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// 
        [MaxLength(500)]
        public string Password { get; set; }

        /// <summary>
        /// 状态 0 正常 1 冻结
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 系统备注
        /// </summary>
        public string Note { get; set; }

        [MaxLength(50)]
        public string Mobile { get; set; }

        [MaxLength(500)]
        public string Tel { get; set; }

        [MaxLength(500)]
        public string OtherTel { get; set; }

        [MaxLength(50)]
        public string Fax { get; set; }

        [MaxLength(500)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string QQ { get; set; }

        [MaxLength(500)]
        public string HeadImg { get; set; }

        [MaxLength(50)]
        public string WeiXin { get; set; }

        public int Sex { get; set; }
    }
}
