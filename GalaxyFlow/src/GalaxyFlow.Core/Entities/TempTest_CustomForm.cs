using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Entities
{
    public class TempTest_CustomForm : Entity
    {
        [MaxLength(500)]
        public string Title { get; set; }

        [MaxLength(4000)]
        public string Contents { get; set; }

        [MaxLength(5000)]
        public string Type { get; set; }

        public int FlowCompleted { get; set; }

        public DateTime wdate { get; set; }

        [MaxLength(5000)]
        public string f1 { get; set; }
                                     
        [MaxLength(5000)]            
        public string f2 { get; set; }
                                     
        [MaxLength(5000)]            
        public string f3 { get; set; }
                                     
        [MaxLength(5000)]            
        public string f4 { get; set; }
                                     
        [MaxLength(5000)]            
        public string f5 { get; set; }
                                     
        [MaxLength(5000)]            
        public string f6 { get; set; }
                                     
        [MaxLength(5000)]            
        public string f7 { get; set; }
                                     
        [MaxLength(5000)]            
        public string f8 { get; set; }

        [MaxLength(5000)]
        public string f9 { get; set; }

        [MaxLength(5000)]
        public string f10 { get; set; }
                                      
        [MaxLength(5000)]             
        public string f11 { get; set; }
                                      
        [MaxLength(5000)]             
        public string f12 { get; set; }
                                      
        [MaxLength(5000)]             
        public string f13 { get; set; }
                                      
        [MaxLength(5000)]             
        public string f14 { get; set; }
                                      
        [MaxLength(5000)]             
        public string f15 { get; set; }
                                      
        [MaxLength(5000)]             
        public string f16 { get; set; }
                                      
        [MaxLength(5000)]             
        public string f17 { get; set; }
                                      
        [MaxLength(5000)]             
        public string f18 { get; set; }
                                      
        [MaxLength(5000)]             
        public string f19 { get; set; }

        [MaxLength(5000)]
        public string f20 { get; set; }
    }
}
