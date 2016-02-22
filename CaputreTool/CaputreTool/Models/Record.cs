using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaputreTool.Models
{
    class Record
    {
        public Person Person { get; set; }
        public RecordProcedure RecordProcedure { get; set; }
        public Situation Situation { get; set; }
        public Accident Accident { get; set; }
        public Symptom Symptom { get; set; }
        public Treatment Treatment { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
