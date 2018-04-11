using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class TempTest_CustomForm : Entity
    {
        [MaxLength(500)]
        public virtual string Title { get; set; }

        [MaxLength(4000)]
        public virtual string Contents { get; set; }

        [MaxLength(5000)]
        public virtual string Type { get; set; }

        public virtual int? FlowCompleted { get; set; }

        public virtual DateTime? wdate { get; set; }

        [MaxLength(5000)]
        public virtual string f1 { get; set; }
                                     
        [MaxLength(5000)]            
        public virtual string f2 { get; set; }
                                     
        [MaxLength(5000)]            
        public virtual string f3 { get; set; }
                                     
        [MaxLength(5000)]            
        public virtual string f4 { get; set; }
                                     
        [MaxLength(5000)]            
        public virtual string f5 { get; set; }
                                     
        [MaxLength(5000)]            
        public virtual string f6 { get; set; }
                                     
        [MaxLength(5000)]            
        public virtual string f7 { get; set; }
                                     
        [MaxLength(5000)]            
        public virtual string f8 { get; set; }

        [MaxLength(5000)]
        public virtual string f9 { get; set; }

        [MaxLength(5000)]
        public virtual string f10 { get; set; }
                                      
        [MaxLength(5000)]             
        public virtual string f11 { get; set; }
                                      
        [MaxLength(5000)]             
        public virtual string f12 { get; set; }
                                      
        [MaxLength(5000)]             
        public virtual string f13 { get; set; }
                                      
        [MaxLength(5000)]             
        public virtual string f14 { get; set; }
                                      
        [MaxLength(5000)]             
        public virtual string f15 { get; set; }
                                      
        [MaxLength(5000)]             
        public virtual string f16 { get; set; }
                                      
        [MaxLength(5000)]             
        public virtual string f17 { get; set; }
                                      
        [MaxLength(5000)]             
        public virtual string f18 { get; set; }
                                      
        [MaxLength(5000)]             
        public virtual string f19 { get; set; }

        [MaxLength(5000)]
        public virtual string f20 { get; set; }
    }
}
