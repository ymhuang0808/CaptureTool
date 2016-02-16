using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaputreTool.Entities
{
    class Situation
    {
        public DateTime DateCreated { get; set; }
        enum Awareness { Clear, VoiceResponse, PainResponse, NoResponse };
        public int BreathFequency { get; set; }
    }
}
