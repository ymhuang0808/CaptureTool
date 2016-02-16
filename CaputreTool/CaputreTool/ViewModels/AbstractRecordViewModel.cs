using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaputreTool.Entities;

namespace CaputreTool.ViewModels
{
    abstract class AbstractRecordViewModel
    {
        public abstract PersonViewModel Person { get; set; }
        public abstract RecordProcedure RecordProcedure { get; set; }
        public abstract Situation Situation { get; set; }
        public abstract Accident Accident { get; set; }
        public abstract Symptom Symptom { get; set; }
        public abstract Treatment Treatment { get; set; }
        public abstract DateTime DateCreated { get; set; }
    }
}
