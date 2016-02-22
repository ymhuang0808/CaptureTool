using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaputreTool.Models
{
    class RecordProcedure
    {
        public String ParentPhoneNumber { get; set; }
        public String ParentName { get; set; }
        public DateTime NotifyParentDateTime { get; set; }

        public DateTime NurseRecivedDateTime { get; set; }
        public DateTime NurseArriveDateTime { get; set; }
        public DateTime NurseLeaveDateTime { get; set; }

        public DateTime AmbulanceNotifyDateTime { get; set; }
        public DateTime AmbulanceArrivedDateTime { get; set; }
        public DateTime AmbulanceLeaveDateTime { get; set; }

        public enum HospitalTransportEnumType { Ambulance, SelfDriving, Taxi, Other }
        public int HospitalTransportType { get; set; }
        public String OtherHospitalTransportType
        {
            get; set;
        }
        public String HospitalName { get; set; }
        public DateTime ArriveHospitalDateTime { get; set; }
    }
}
