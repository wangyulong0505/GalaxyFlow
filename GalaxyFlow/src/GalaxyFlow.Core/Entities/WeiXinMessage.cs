using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class WeiXinMessage : Entity<Guid>
    {
        [MaxLength(200)]
        public string ToUserName { get; set; }

        [MaxLength(200)]
        public string FromUserName { get; set; }

        public int CreateTime { get; set; }

        public DateTime CreateTime1 { get; set; }

        [MaxLength(50)]
        public string MsgType { get; set; }

        public double MsgId { get; set; }

        public int AgentID { get; set; }

        public string Contents { get; set; }

        [MaxLength(500)]
        public string PicUrl { get; set; }

        [MaxLength(50)]
        public string MediaId { get; set; }

        [MaxLength(50)]
        public string Format { get; set; }

        [MaxLength(50)]
        public string ThumbMediaId { get; set; }

        [MaxLength(50)]
        public string Location_X { get; set; }

        [MaxLength(50)]
        public string Location_Y { get; set; }

        [MaxLength(50)]
        public string Scale { get; set; }

        [MaxLength(500)]
        public string Label { get; set; }

        [MaxLength(500)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public DateTime AddTime { get; set; }
    }
}
