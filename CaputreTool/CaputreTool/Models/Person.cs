using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaputreTool.Models
{
    class Person
    {
        public int number { get; set; }
        public String name { get; set; }

        public enum Genders { Male, Female };
        public int gender { get; set; } 

        public String className { get; set; }
    }
}
