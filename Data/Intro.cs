using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewProject1.Data
{
    public class Intro
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SID { get; set; }
        public string GED { get; set; }
        public string HSED { get; set; }
        public string CONTINUINGEDUCATION { get; set; }
        public string EMPLOYMENT { get; set; }
        public string CHILDCARE { get; set; }
    }
}
