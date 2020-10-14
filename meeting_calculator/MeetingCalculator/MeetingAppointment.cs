using System;

namespace MeetingCalculator
{
    public class MeetingAppointment
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string AppointmentText { get; set; }

        public MeetingAppointment(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public MeetingAppointment(DateTime startTime, DateTime endTime, string appointmentText)
        {
            StartTime = startTime;
            EndTime = endTime;
            AppointmentText = appointmentText;
        }
    }
}
