using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Models
{
    public static class AppointmentRepository
    {
        public static IList<DefaultSchedule> GetAllRecords()
        {
            IList<DefaultSchedule> appoint = (IList<DefaultSchedule>)HttpContext.Current.Session["Appointments"];
            if (appoint == null)
                HttpContext.Current.Session["Appointments"] = appoint = new ScheduleDataDataContext().DefaultSchedules.ToList();
            return appoint;
        }

        public static DefaultSchedule Insert(DefaultSchedule app)
        {
            DateTime startTime = Convert.ToDateTime(app.StartTime);
            DateTime endTime = Convert.ToDateTime(app.EndTime);
            DefaultSchedule appoint = new DefaultSchedule()
            {
                Id = app.Id,
                StartTime = startTime,
                EndTime = endTime,
                Subject = app.Subject,
                StartTimeZone = app.StartTimeZone,
                EndTimeZone = app.EndTimeZone,
                Recurrence = app.Recurrence,
                AllDay = app.AllDay,
                RecurrenceRule = app.RecurrenceRule,
            };
            GetAllRecords().Insert(0, appoint);
            return appoint;
        }

        public static DefaultSchedule Insert(List<DefaultSchedule> appoint)
        {
            foreach (var temp in appoint)
            {
                DateTime startTime = Convert.ToDateTime(temp.StartTime);
                DateTime endTime = Convert.ToDateTime(temp.EndTime);
                DefaultSchedule appObject = new DefaultSchedule()
                {
                    Id = temp.Id,
                    StartTime = startTime,
                    EndTime = endTime,
                    Subject = temp.Subject,
                    StartTimeZone = temp.StartTimeZone,
                    EndTimeZone = temp.EndTimeZone,
                    Recurrence = temp.Recurrence,
                    AllDay = temp.AllDay,
                    RecurrenceRule = temp.RecurrenceRule,
                };
                GetAllRecords().Insert(0, appObject);
            }
            return appoint[0];
        }

        public static DefaultSchedule Remove(int appId)
        {
            DefaultSchedule removeApp = GetAllRecords().Where(c => c.Id == appId).FirstOrDefault();
            if (removeApp != null)
                GetAllRecords().Remove(removeApp);
            return removeApp;
        }

        public static DefaultSchedule Update(DefaultSchedule app)
        {
            DefaultSchedule appoint = null;
            var filterData = GetAllRecords().Where(c => c.Id == Convert.ToInt32(app.Id));
            if (filterData.Count() > 0)
            {
                DateTime startTime = Convert.ToDateTime(app.StartTime);
                DateTime endTime = Convert.ToDateTime(app.EndTime);
                appoint = GetAllRecords().Single(A => A.Id == Convert.ToInt32(app.Id));
                appoint.StartTime = startTime;
                appoint.EndTime = endTime;
                appoint.StartTimeZone = app.StartTimeZone;
                appoint.EndTimeZone = app.EndTimeZone;
                appoint.Subject = app.Subject;
                appoint.Recurrence = app.Recurrence;
                appoint.AllDay = app.AllDay;
                appoint.RecurrenceRule = app.RecurrenceRule;
            }
            return appoint;
            
        }

        public static List<DefaultSchedule> FilterAppointment(DateTime CurrentDate, String CurrentAction, String CurrentView)
        {
            DateTime CurrDate = Convert.ToDateTime(CurrentDate);
            DateTime StartDate = FirstWeekDate(CurrDate.Date);
            DateTime EndDate = FirstWeekDate(CurrDate.Date);
            List<DefaultSchedule> appointmentList = GetAllRecords().ToList();
            switch (CurrentView)
            {
                case "day":
                    StartDate = CurrentDate;
                    EndDate = CurrentDate;
                    break;
                case "week":
                    EndDate = EndDate.AddDays(7);
                    break;
                case "workweek":
                    EndDate = EndDate.AddDays(5);
                    break;
                case "month":
                    StartDate = CurrDate.Date.AddDays(-CurrDate.Day + 1);
                    EndDate = StartDate.AddMonths(1);
                    break;
            }
            DateTime st;  DateTime et;
            appointmentList = GetAllRecords().ToList().Where(app => DateTime.TryParse(app.StartTime.ToString(), out st) &&      
                ((st.ToLocalTime().Date >= Convert.ToDateTime(StartDate.Date)) &&
                DateTime.TryParse(app.EndTime.ToString(), out et) &&
                (et.ToLocalTime().Date <= Convert.ToDateTime(EndDate.Date))) || app.Recurrence == 1).ToList();
            return appointmentList;
        }

        internal static DateTime FirstWeekDate(DateTime CurrentDate)
        {
            try
            {
                DateTime FirstDayOfWeek = CurrentDate;
                DayOfWeek WeekDay = FirstDayOfWeek.DayOfWeek;
                switch (WeekDay)
                {
                    case DayOfWeek.Sunday:
                        break;
                    case DayOfWeek.Monday:
                        FirstDayOfWeek = FirstDayOfWeek.AddDays(-1);
                        break;
                    case DayOfWeek.Tuesday:
                        FirstDayOfWeek = FirstDayOfWeek.AddDays(-2);
                        break;
                    case DayOfWeek.Wednesday:
                        FirstDayOfWeek = FirstDayOfWeek.AddDays(-3);
                        break;
                    case DayOfWeek.Thursday:
                        FirstDayOfWeek = FirstDayOfWeek.AddDays(-4);
                        break;
                    case DayOfWeek.Friday:
                        FirstDayOfWeek = FirstDayOfWeek.AddDays(-5);
                        break;
                    case DayOfWeek.Saturday:
                        FirstDayOfWeek = FirstDayOfWeek.AddDays(-6);
                        break;
                }
                return (FirstDayOfWeek);
            }
            catch
            {
                return DateTime.Now;
            }
        }
    }
}