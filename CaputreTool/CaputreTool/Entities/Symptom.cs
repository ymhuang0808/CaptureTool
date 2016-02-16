using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaputreTool.Entities
{
    class Symptom
    {
        enum EnumTypes { Dizziness, LimbWeakness, Vomit, Other }
        public int type { get; set; }
        public String OtherType { get; set; }
        public String From { get; set; }
    }
}
