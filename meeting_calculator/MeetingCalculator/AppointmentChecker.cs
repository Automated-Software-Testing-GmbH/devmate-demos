using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MeetingCalculator
{
    public class AppointmentChecker
    {
        public List<MeetingAppointment> CurrentCalenderEntries { get; set; } = null;

        public AppointmentChecker(List<MeetingAppointment> currentCalendarEntries)
        {
            CurrentCalenderEntries = currentCalendarEntries;
        }

        public bool CheckAppointment(MeetingAppointment meeting)
        {
            if (CurrentCalenderEntries == null) throw new Exception("Calendar can not be null");
            if (meeting == null) return false;
            if (CurrentCalenderEntries == null) return false;

            foreach (MeetingAppointment cur in CurrentCalenderEntries)
            {
                if (cur.StartTime.Ticks >= cur.EndTime.Ticks) throw new Exception("Start must be before End");
                if (meeting.StartTime.Ticks >= meeting.EndTime.Ticks) throw new Exception("Start Time of Meeting2Check must be before End Time");

                if (cur.StartTime.Ticks <= meeting.StartTime.Ticks && meeting.StartTime.Ticks < cur.EndTime.Ticks)
                {
                    return false;
                }
                if (cur.StartTime.Ticks < meeting.EndTime.Ticks && meeting.EndTime.Ticks <= cur.EndTime.Ticks)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
