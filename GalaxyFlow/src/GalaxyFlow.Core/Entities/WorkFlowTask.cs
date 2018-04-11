using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class WorkFlowTask : Entity<Guid>
    {
        public virtual Guid PrevID { get; set; }

        public virtual Guid PrevStepID { get; set; }

        public virtual Guid FlowID { get; set; }

        public virtual Guid StepID { get; set; }

        [MaxLength(500)]
        public virtual string StepName { get; set; }

        [MaxLength(50)]
        public virtual string InstanceID { get; set; }

        public virtual Guid GroupID { get; set; }

        public virtual int Type { get; set; }

        [MaxLength(500)]
        public virtual string Title { get; set; }

        public virtual Guid SenderID { get; set; }

        [MaxLength(500)]
        public virtual string SenderName { get; set; }

        public virtual DateTime SenderTime { get; set; }

        public virtual Guid ReceiveID { get; set; }

        [MaxLength(500)]
        public virtual string ReceiveName { get; set; }

        public virtual DateTime ReceiveTime { get; set; }

        public virtual DateTime? OpenTime { get; set; }

        public virtual DateTime? CompletedTime { get; set; }

        public virtual DateTime? CompletedTime1 { get; set; }

        [MaxLength(4000)]
        public virtual string Comment { get; set; }

        public virtual int? IsSign { get; set; }

        public virtual int Status { get; set; }

        public virtual string Note { get; set; }

        public virtual int Sort { get; set; }

        public virtual string SubFlowGroupID { get; set; }

        public virtual int? OtherType { get; set; }

        public virtual string Files { get; set; }

        public virtual int IsExpiredAutoSubmit { get; set; }

        public virtual int StepSort { get; set; }
    }
}
