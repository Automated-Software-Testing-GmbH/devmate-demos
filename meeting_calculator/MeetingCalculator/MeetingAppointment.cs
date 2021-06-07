using System;
using System.Collections.Generic;
using System.Text;

namespace MeetingCalculator
{
    public class MeetingAppointment
    {

        public enum MeetingType
        {
            privateMeeting,
            jobMeeting,
            videoCall
        }

        public MeetingType typeOfMeeting { get; set; }

        private DateTime startTime;

        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        private DateTime endTime;

        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        public string AppointmentText { get; set; }

        public MeetingAppointment()
        {
            StartTime = DateTime.Now;
            StartTime = new DateTime(StartTime.Year, StartTime.Month, startTime.Day, startTime.Hour + 1, 0, 0);
            EndTime = new DateTime(StartTime.Year, StartTime.Month, startTime.Day, startTime.Hour + 2, 0, 0);
            AppointmentText = "new Meeting Reserved";
        }
        public MeetingAppointment(DateTime start, DateTime end)
        {
            StartTime = start;
            EndTime = end;
        }

        public MeetingAppointment(DateTime start, DateTime end, string appointmentText)
        {
            StartTime = start;
            EndTime = end;
            AppointmentText = appointmentText;
        }
        public MeetingAppointment(DateTime start, DateTime end, string appointmentText, MeetingType type)
        {
            StartTime = start;
            EndTime = end;
            AppointmentText = appointmentText;
            typeOfMeeting = type;
        }
        public void substract(int x)
        {

        }
        

        public override bool Equals(object obj)
        {
            try
            {
                MeetingAppointment m = (MeetingAppointment)obj;
                if (m.startTime == this.startTime && m.endTime == this.endTime && this.AppointmentText == m.AppointmentText && this.typeOfMeeting == m.typeOfMeeting)
                {
                    return true;
                }
            }
            catch { }
            return base.Equals(obj);
        }

    }
}
