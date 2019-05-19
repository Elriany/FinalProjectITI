using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class FeesCustom
    {
        public int id { get; set; }
        public decimal total { get; set; }
        public decimal paid { get; set; }
        public decimal reminder { get; set; }
    }
}
