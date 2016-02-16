using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaputreTool.Entities
{
    class Accident
    {
        enum EnumTypes { Falls, Drop, Fracture, Other };
        public int type { get; set; }
        public String OtherType;

        public enum Witnesses { Student, Teacher, Other };
        public String OtherWitness;
    }
}
