using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaputreTool.Models
{
    class Treatment
    {
        enum EnumTypes { CPR, Oxygen, Wrap, Other };
        public int type { get; set; } 
        public String OtherType { get; set; }
        public int CPRMinutes { get; set; }
    }
}
