#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSampleBrowser.Models
{
    public class ScheduleQueryCellInfo
    {
        public List<ScheduleAppointmentsObjData> GetRecords()
        {
            List<ScheduleAppointmentsObjData> list = new List<ScheduleAppointmentsObjData>();
            list.Add(new ScheduleAppointmentsObjData(1, "Maintenance", "05/30/2017 02:30:00 AM", "05/30/2017 04:00:00 AM", "", "1", "1", false, false, "Maintenance", "UTC +05:30", "UTC +05:30"));
            list.Add(new ScheduleAppointmentsObjData(2, "Technology Book Stall", "06/05/2017 01:30:00 AM", "06/05/2017 05:00:00 AM", "", "1", "1", false, false, "Public Event", "UTC +05:30", "UTC +05:30"));
            list.Add(new ScheduleAppointmentsObjData(3, "Technology Book Stall", "06/15/2017 01:30:00 AM", "06/15/2017 05:00:00 AM", "", "1", "1", false, false, "Public Event", "UTC +05:30", "UTC +05:30"));
            list.Add(new ScheduleAppointmentsObjData(4, "Technology Book Stall", "06/12/2017 01:30:00 AM", "06/12/2017 05:00:00 AM", "", "1", "2", false, false, "Public Event", "UTC +05:30", "UTC +05:30"));
            list.Add(new ScheduleAppointmentsObjData(5, "Annual Conference", "06/05/2017 06:30:00 AM", "06/05/2017 09:00:00 AM", "", "1", "1", false, false, "Commercial Event", "UTC +05:30", "UTC +05:30"));
            list.Add(new ScheduleAppointmentsObjData(6, "Annual Conference", "06/15/2017 06:30:00 AM", "06/15/2017 09:00:00 AM", "", "1", "1", false, false, "Commercial Event", "UTC +05:30", "UTC +05:30"));
            list.Add(new ScheduleAppointmentsObjData(7, "Annual Conference", "06/10/2017 06:30:00 AM", "06/10/2017 09:00:00 AM", "", "1", "2", false, false, "Commercial Event", "UTC +05:30", "UTC +05:30"));
            list.Add(new ScheduleAppointmentsObjData(8, "IMI Meeting", "06/05/2017 06:30:00 AM", "06/05/2017 09:00:00 AM", "International Management Institute", "2", "3", false, false, "Commercial Event", "UTC +05:30", "UTC +05:30"));
            list.Add(new ScheduleAppointmentsObjData(9, "George Birthday Celebration", "06/05/2017 05:00:00 AM", "06/05/2017 08:00:00 AM", "4th Year Celebration", "1", "2", false, false, "Family Event", "UTC +05:30", "UTC +05:30"));
            list.Add(new ScheduleAppointmentsObjData(10, "John Wedding Aniversary", "06/02/2017 06:00:00 AM", "06/02/2017 09:00:00 AM", "1st Year Celebration", "2", "3", false, false, "Family Event", "UTC +05:30", "UTC +05:30"));
            return list;
        }
    }
    [Serializable]
    public class ScheduleAppointmentsObjData
    {
        private int _id;
        private String _subject;
        private String _startTime;
        private String _endTime;
        private String _description;
        private String _owner;
        private Boolean _recurrence;
        private Boolean _allDay;
        private String _startTimeZone;
        private String _endTimeZone;
        private String _room;
        private String _eventType;

        public ScheduleAppointmentsObjData()
        {

        }
        public ScheduleAppointmentsObjData(int _id, string _subject, string _startTime, string _endTime, string _description, string _room, string _owner, bool _recurrence, bool _allDay, string _eventType, string _startTimeZone, string _endTimeZone)
        {
            this._id = _id;
            this._subject = _subject;
            this._startTime = _startTime;
            this._endTime = _endTime;
            this._description = _description;
            this._owner = _owner;
            this._room = _room;
            this._recurrence = _recurrence; ;
            this._allDay = _allDay;
            this._eventType = _eventType;
            this._startTimeZone = _startTimeZone;
            this._endTimeZone = _endTimeZone;
        }
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
            }
        }
        public string RoomId
        {
            get
            {
                return _room;
            }
            set
            {
                _room = value;
            }
        }
        public string EventType
        {
            get
            {
                return _eventType;
            }
            set
            {
                _eventType = value;
            }
        }
        public string StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
            }
        }
        public string EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public string OwnerId
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
            }
        }
        public Boolean Recurrence
        {
            get
            {
                return _recurrence;
            }
            set
            {
                _recurrence = value;
            }
        }
        public Boolean AllDay
        {
            get
            {
                return _allDay;
            }
            set
            {
                _allDay = value;
            }
        }
        public string StartTimeZone
        {
            get
            {
                return _startTimeZone;
            }
            set
            {
                _startTimeZone = value;
            }
        }
        public string EndTimeZone
        {
            get
            {
                return _endTimeZone;
            }
            set
            {
                _endTimeZone = value;
            }
        }
    }
}