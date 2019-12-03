using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewProject1.Data
{
    public class Orientation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SID{ get; set; }
        public string DailyGoals { get; set; }
        public string WeeklyGoals { get; set; }
        public string MonthlyGoals { get; set; }
        public string YearlyGoals { get; set; }
    }
}
