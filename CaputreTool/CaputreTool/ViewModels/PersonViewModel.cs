using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaputreTool.ViewModels
{
    class PersonViewModel
    {
        public int number { get; set; }
        public string name { get; set; }

        public enum Genders { Male, Female };
        public int gender { get; set; } 
    }
}
