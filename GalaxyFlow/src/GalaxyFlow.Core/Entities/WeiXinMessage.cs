using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class WeiXinMessage : Entity<Guid>
    {
        [MaxLength(200)]
        public virtual string ToUserName { get; set; }

        [MaxLength(200)]
        public virtual string FromUserName { get; set; }

        public virtual int CreateTime { get; set; }

        public virtual DateTime CreateTime1 { get; set; }

        [MaxLength(50)]
        public virtual string MsgType { get; set; }

        public virtual double MsgId { get; set; }

        public virtual int AgentID { get; set; }

        public virtual string Contents { get; set; }

        [MaxLength(500)]
        public virtual string PicUrl { get; set; }

        [MaxLength(50)]
        public virtual string MediaId { get; set; }

        [MaxLength(50)]
        public virtual string Format { get; set; }

        [MaxLength(50)]
        public virtual string ThumbMediaId { get; set; }

        [MaxLength(50)]
        public virtual string Location_X { get; set; }

        [MaxLength(50)]
        public virtual string Location_Y { get; set; }

        [MaxLength(50)]
        public virtual string Scale { get; set; }

        [MaxLength(500)]
        public virtual string Label { get; set; }

        [MaxLength(500)]
        public virtual string Title { get; set; }

        [MaxLength(1000)]
        public virtual string Description { get; set; }

        public virtual DateTime AddTime { get; set; }
    }
}
