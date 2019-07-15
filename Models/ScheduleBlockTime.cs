#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
    public class ScheduleBlockTime
    {
        #region Create DataSource for Block Intervals
        public List<BlockDataSource> GetBlockData()
        {
            List<BlockDataSource> data = new List<BlockDataSource>();
            data.Add(new BlockDataSource { Id = 1, Subject = "MAINTENANCE", StartTime = new DateTime(2017, 6, 5, 8, 0, 0), EndTime = new DateTime(2017, 6, 5, 10, 0, 0), BlockAppointment = true, ResourceId = "3", GroupId = "2", FullDay = false });
            data.Add(new BlockDataSource { Id = 2, Subject = "SERVICE", StartTime = new DateTime(2017, 6, 5, 9, 0, 0), EndTime = new DateTime(2017, 6, 5, 11, 0, 0), BlockAppointment = true, ResourceId = "1", GroupId = "1", FullDay = false });
            data.Add(new BlockDataSource { Id = 3, Subject = "SERVICE", StartTime = new DateTime(2017, 6, 6), EndTime = new DateTime(2017, 6, 6), BlockAppointment = true, ResourceId = "1", GroupId = "1", FullDay = true });
            data.Add(new BlockDataSource { Id = 4, Subject = "BAD MONSOON", StartTime = new DateTime(2017, 6, 5, 15, 30, 0), EndTime = new DateTime(2017, 6, 5, 17, 0, 0), BlockAppointment = true, ResourceId = "1", GroupId = "1", FullDay = false });
            data.Add(new BlockDataSource { Id = 5, Subject = "BAD MONSOON", StartTime = new DateTime(2017, 6, 5, 15, 30, 0), EndTime = new DateTime(2017, 6, 5, 17, 0, 0), BlockAppointment = true, ResourceId = "3", GroupId = "2", FullDay = false });
            data.Add(new BlockDataSource { Id = 6, Subject = "BAD MONSOON", StartTime = new DateTime(2017, 6, 5, 15, 30, 0), EndTime = new DateTime(2017, 6, 5, 17, 0, 0), BlockAppointment = true, ResourceId = "5", GroupId = "1", FullDay = false });
            return data;
        }
        #endregion
        #region Create DataSource for Appointments
        public List<ScheduleAppointmentsData> GetAppointmentData()
        {
            List<ScheduleAppointmentsData> list = new List<ScheduleAppointmentsData>();
            list.Add(new ScheduleAppointmentsData { Id = 1, Subject = "#SG 208 Greenville - Washington", StartTime = new DateTime(2017, 6, 5, 12, 0, 0), EndTime = new DateTime(2017, 6, 5, 13, 30, 0), Description = "", OwnerId = "3", RoomId = "2", Recurrence = true, RecurrenceRule = "FREQ=DAILY;INTERVAL=2;COUNT=10", AllDay = false });
            list.Add(new ScheduleAppointmentsData { Id = 2, Subject = "#IT 188 Washington - Arizona", StartTime = new DateTime(2017, 6, 5, 4, 0, 0), EndTime = new DateTime(2017, 6, 5, 5, 0, 0), Description = "", OwnerId = "3", RoomId = "2", Recurrence = false, RecurrenceRule = "", AllDay = false });
            list.Add(new ScheduleAppointmentsData { Id = 3, Subject = "#SG 300 Chicago - Nevada", StartTime = new DateTime(2017, 6, 5, 11, 30, 0), EndTime = new DateTime(2017, 6, 5, 13, 0, 0), Description = "", OwnerId = "1", RoomId = "1", Recurrence = true, RecurrenceRule = "FREQ=DAILY;INTERVAL=2;COUNT=10", AllDay = false });
            list.Add(new ScheduleAppointmentsData { Id = 4, Subject = "#IT 306 Washington - Newport", StartTime = new DateTime(2017, 6, 5, 4, 0, 0), EndTime = new DateTime(2017, 6, 5, 5, 0, 0), Description = "", OwnerId = "5", RoomId = "1", Recurrence = true, RecurrenceRule = "FREQ=DAILY;INTERVAL=2;COUNT=10", AllDay = false });
            list.Add(new ScheduleAppointmentsData { Id = 5, Subject = "#AI 520 Washington - Chicago", StartTime = new DateTime(2017, 6, 5, 12, 30, 0), EndTime = new DateTime(2017, 6, 5, 13, 30, 0), Description = "", OwnerId = "5", RoomId = "2", Recurrence = false, RecurrenceRule = "", AllDay = false });
            list.Add(new ScheduleAppointmentsData { Id = 6, Subject = "#SG 345 Renfrewshire - Lancashire", StartTime = new DateTime(2017, 6, 5, 6, 30, 0), EndTime = new DateTime(2017, 6, 5, 7, 30, 0), Description = "", OwnerId = "3", RoomId = "2", Recurrence = false, RecurrenceRule = "", AllDay = false });
            return list;
        }
        #endregion
    }
    [Serializable]
    public class BlockDataSource
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Boolean BlockAppointment { get; set; }
        public string ResourceId { get; set; }
        public string GroupId { get; set; }
        public bool FullDay { get; set; }
    }
    [Serializable]
    public class ScheduleAppointmentsData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string OwnerId { get; set; }
        public string RoomId { get; set; }
        public Boolean Recurrence { get; set; }
        public String RecurrenceRule { get; set; }
        public Boolean AllDay { get; set; }
    }
}