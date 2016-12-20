using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_13_TipCalc.Models
{
    public class Tip
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Percentage { get; set; }
        public decimal FixedAmount { get; set; }
        public bool IsFixedTip { get; set; }
    }
}
