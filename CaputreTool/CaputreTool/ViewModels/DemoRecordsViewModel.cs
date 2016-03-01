using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaputreTool.Models;

namespace CaputreTool.ViewModels
{
    class DemoRecordsViewModel : AbstractRecordViewModel
    {
        private ObservableCollection<Record> _recordItems;

        public override ObservableCollection<Record> RecordItems
        {
            get
            {
                return _recordItems;
            }

            set
            {
                _recordItems = value;
            }
        }

        public override ObservableCollection<Record> GetRecordItems(int number)
        {
            RecordItems = new ObservableCollection<Record>();
            RecordItems.Clear();

            for (int i = 0; i < number; i++)
            {
                RecordItems.Add(makeRecord("Demo" + i, i, "Demo Parent" + i, "091012345" + i));
            }

            return RecordItems;
        }

        private Person makePerson(String name, int number)
        {
            Person person = new Person();
            person.name = name;
            person.number = number;
            return person;
        }

        private DateTime makeDateCreated()
        {
            DateTime dateCreated = DateTime.Now;
            return dateCreated;
        }

        private RecordProcedure makeRecordProcedure(String parentName, String parentPhonNumber)
        {
            RecordProcedure recordProcedure = new RecordProcedure();
            recordProcedure.ParentName = parentName;
            recordProcedure.ParentPhoneNumber = parentPhonNumber;
            recordProcedure.NotifyParentDateTime = new DateTime(2016, 02, 21, 10, 31, 40);
            recordProcedure.NurseRecivedDateTime = new DateTime(2016, 02, 21, 10, 29, 12);
            recordProcedure.NurseArriveDateTime = new DateTime(2016, 02, 21, 10, 31, 33);
            recordProcedure.NurseLeaveDateTime = new DateTime(2016, 02, 21, 10, 44, 22);

            recordProcedure.AmbulanceNotifyDateTime = new DateTime(2016, 02, 21, 10, 30, 2);
            recordProcedure.AmbulanceArrivedDateTime = new DateTime(2016, 02, 21, 10, 41, 15);
            recordProcedure.AmbulanceLeaveDateTime = new DateTime(2016, 02, 21, 10, 43, 45);
            recordProcedure.HospitalTransportType = (int)RecordProcedure.HospitalTransportEnumType.Ambulance;
            recordProcedure.HospitalName = "NTU Hospital";
            recordProcedure.ArriveHospitalDateTime = new DateTime(2016, 02, 21, 10, 48, 51);

            return recordProcedure;
        }

        private Situation makeSituation(int awarenessType, int breathFrequency)
        {
            Situation situation = new Situation();
            situation.DateCreated = new DateTime(2016, 02, 21, 10, 33, 9);
            situation.awarenessType = awarenessType;
            situation.BreathFequency = breathFrequency;

            return situation;
        }

        private Record makeRecord(String name, int number, String parentName, String parentPhoneNumber)
        {
            Record record = new Record();
            record.Person = makePerson(name, number);
            record.DateCreated = makeDateCreated();
            record.RecordProcedure = makeRecordProcedure(parentName, parentPhoneNumber);
            record.Situation = makeSituation((int)Situation.AwarenessEnumType.NoResponse, 30);

            return record;
        }
    }
}
