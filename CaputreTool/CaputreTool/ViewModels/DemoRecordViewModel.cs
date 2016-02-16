using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaputreTool.Entities;

namespace CaputreTool.ViewModels
{
    class DemoRecordViewModel : AbstractRecordViewModel
    {
        private PersonViewModel _person;
        private RecordProcedure _recordProcedure;

        public override PersonViewModel Person
        {
            get
            {
                _person = new PersonViewModel();
                _person.number = 1;
                _person.name = "Jbb";
                _person.gender = (int)PersonViewModel.Genders.Male;

                return _person;
            }
            set
            {
                _person = value;
            }
        }
        public override RecordProcedure RecordProcedure
        {
            get
            {
                _recordProcedure = new RecordProcedure();
                _recordProcedure.ParentName = "JBaBa";
                _recordProcedure.ParentPhoneNumber = "54321";

                return _recordProcedure;
            }
            set
            {
                _recordProcedure = value;
            }
        }
        public override Situation Situation { get; set; }
        public override Accident Accident { get; set; }
        public override Symptom Symptom { get; set; }
        public override Treatment Treatment { get; set; }
        public override DateTime DateCreated { get; set; }
    }
}
