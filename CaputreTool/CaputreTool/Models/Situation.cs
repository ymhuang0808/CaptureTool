using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaputreTool.Models
{
    class Situation
    {
        public DateTime DateCreated { get; set; }
        public enum AwarenessEnumType { Clear, VoiceResponse, PainResponse, NoResponse };
        public int awarenessType { get; set; }
        public int BreathFequency { get; set; }
    }
}
