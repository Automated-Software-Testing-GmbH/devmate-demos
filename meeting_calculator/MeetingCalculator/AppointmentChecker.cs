using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MeetingCalculator
{
    public class AppointmentChecker
    {
        List<MeetingAppointment> actualMeetingAppointments = null;

        public List<MeetingAppointment> CurrentCalenderEntries { get => actualMeetingAppointments; set => actualMeetingAppointments = value; }

        public AppointmentChecker()
        {

        }

        public AppointmentChecker(List<MeetingAppointment> currentCalendarEntries)
        {
            CurrentCalenderEntries = (List<MeetingAppointment>)currentCalendarEntries;
        }

        public bool ContainsMeeting(List<MeetingAppointment> MeetingList, MeetingAppointment contains)
        {
            return MeetingList.Contains(contains);
        }


        /// <summary>
        /// Checkes if the local calendar has still space for an new given appointment 
        /// or if there is any kind of scheduling conflict. 
        /// </summary>
        /// <param name="Meeting2check">the new Meeting to check</param>
        /// <returns>true if there is no scheduling conflict, false if there is a scheduling conflict</returns>
        public bool CheckAppointment(MeetingAppointment Meeting2check)
        {
            if (CurrentCalenderEntries == null)
                throw new Exception("Calendar can not be null");
            if (Meeting2check == null)
                throw new Exception("Meeting2check can not be null");
            if (Meeting2check.StartTime.Ticks >= Meeting2check.EndTime.Ticks)
                throw new Exception("Event or Backwards in time");


            foreach (MeetingAppointment cur in CurrentCalenderEntries)
            {
                if (cur.StartTime.Ticks >= cur.EndTime.Ticks)
                    throw new Exception("Event or Backwards in time");

                if (cur.StartTime.Ticks <= Meeting2check.StartTime.Ticks && Meeting2check.StartTime.Ticks < cur.EndTime.Ticks)
                {
                    return false;
                }
                if (cur.StartTime.Ticks < Meeting2check.EndTime.Ticks && Meeting2check.EndTime.Ticks <= cur.EndTime.Ticks)
                {
                    return false;
                }
                if (Meeting2check.StartTime <= cur.StartTime && cur.EndTime <= Meeting2check.EndTime)
                {
                    return false;
                }
            }
            return true;

        }

        public int GiveMeTheLongMeetings(List<MeetingAppointment> MeetingList)
        {
            return 0;
        }

        public bool RemoveMeeting(MeetingAppointment oldMeeting2delete)
        {
            if (CurrentCalenderEntries == null)
                throw new Exception("Calendar can not be null");
            if (oldMeeting2delete == null)
                throw new Exception("Meeting2check can not be null");
            if (oldMeeting2delete.StartTime.Ticks >= oldMeeting2delete.EndTime.Ticks)
                throw new Exception("Event or Backwards in time");

            if (actualMeetingAppointments.Contains(oldMeeting2delete))
            {
                this.actualMeetingAppointments.Remove(oldMeeting2delete);
                return true;
            }
            return false;
        }

        public MeetingAppointment ChangeMeeting(MeetingAppointment oldMeeting2change, DateTime StartTime, DateTime EndTime)
        {
            string date = "12.09.1990 13:00:00";
            DateTime dt = DateTime.Now;
            new DateTime(2020, 12, 02, 13, 00, 00);
            bool b = DateTime.TryParse(date, out dt);

            oldMeeting2change.StartTime = StartTime;
            oldMeeting2change.EndTime = EndTime;
            return oldMeeting2change;
        }

        public void AsessNewMeeting(MeetingAppointment newExMeeting2Asess4Managemen)
        {

        }



        public bool NewMeeting(MeetingAppointment newMeeting2Add)
        {
            actualMeetingAppointments.Add(newMeeting2Add);
            return true;
        }

        /// <summary>
        /// Finds the next fit for a Meeting between 8:00 and 23:59 on a given day within the given Calendar
        /// </summary>
        /// <param name="text">Text/Description of the Meeting</param>
        /// <param name="dayToFitMeeting">day to find the space for the Meeting</param>
        /// <param name="durationHours">Hours of the new Meeting</param>
        /// <param name="durationMinutes">Minutes of the new Meeting</param>
        /// <returns>null if no meeting can be found, or the new meeting in the calendar</returns>
        public MeetingAppointment FindNextFit(string text, DateTime dayToFitMeeting, int durationHours, int durationMinutes)
        {
            TimeSpan Span2Find = new TimeSpan(durationHours, durationMinutes, 0);
            if (CurrentCalenderEntries == null)
                throw new Exception("Need valid Calendar");
            if (durationHours < 0 || durationMinutes < 0)
                throw new Exception("Invalid TimeSpan, Negativ Value");

            List<MeetingAppointment> List2Search = new List<MeetingAppointment>();
            List2Search.Add(new MeetingAppointment(new DateTime(dayToFitMeeting.Year, dayToFitMeeting.Month, dayToFitMeeting.Day, 8, 0, 0), new DateTime(dayToFitMeeting.Year, dayToFitMeeting.Month, dayToFitMeeting.Day, 8, 0, 0)));
            foreach (var cur in CurrentCalenderEntries)
            {
                if (cur.StartTime.Ticks >= cur.EndTime.Ticks)
                    throw new Exception("Calendar invalid, Event or BackwardsMeeting detected");
                if (cur.StartTime.Year == dayToFitMeeting.Year && cur.StartTime.Month == dayToFitMeeting.Month && cur.StartTime.Day == dayToFitMeeting.Day)
                    List2Search.Add(cur);
            }
            List2Search.Add(new MeetingAppointment(new DateTime(dayToFitMeeting.Year, dayToFitMeeting.Month, dayToFitMeeting.Day, 23, 59, 0), new DateTime(dayToFitMeeting.Year, dayToFitMeeting.Month, dayToFitMeeting.Day, 8, 23, 59)));
            var calAr = List2Search.ToArray();
            for (int i = 0; i < calAr.Length - 1; i++)
            {
                DateTime BreakStart = calAr[i].EndTime;
                var nextMeetingIndex = i + 1;
                DateTime BreakEnd = calAr[nextMeetingIndex].StartTime;
                TimeSpan BreakSpan = BreakEnd - BreakStart;
                if (BreakSpan.Ticks >= Span2Find.Ticks)
                {
                    DateTime newMeetingEnd = new DateTime(dayToFitMeeting.Year, dayToFitMeeting.Month, dayToFitMeeting.Day, BreakStart.Hour + durationHours, BreakStart.Minute + durationMinutes, 0);
                    if (text != null)
                    {
                        var newAppointmentMeeting = new MeetingAppointment(BreakStart, newMeetingEnd, text);
                        CurrentCalenderEntries.Add(newAppointmentMeeting);
                        return newAppointmentMeeting;
                    }
                    else
                    {
                        var newAppointment = new MeetingAppointment(BreakStart, newMeetingEnd);
                        CurrentCalenderEntries.Add(newAppointment);
                        return newAppointment;
                    }

                }
            }
            return null;
        }

        public MeetingAppointment ChangeMeetingType(MeetingAppointment meeting2Change, MeetingAppointment.MeetingType typeOfMeeting)
        {
            if (meeting2Change == null)
                throw new Exception("Meeting 2 change was null");
            if (meeting2Change.StartTime.Ticks >= meeting2Change.EndTime.Ticks)
                throw new Exception("meeting Invalid, Event or Backwards in time");
            meeting2Change.typeOfMeeting = typeOfMeeting;
            return meeting2Change;
        }

        public override bool Equals(object obj)
        {
            try
            {
                var appCh = (AppointmentChecker)obj;
                var CalE = appCh.CurrentCalenderEntries;
                if (CurrentCalenderEntries.Count != CalE.Count)
                    return false;
                foreach (var e in CurrentCalenderEntries)
                {
                    if (!CalE.Contains(e))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            { }
            return false;
        }
    }
}