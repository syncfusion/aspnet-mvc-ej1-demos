using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCSampleBrowser.Models
{
    public class ResultParams
    {
        public string key { get; set; }
        public string action { get; set; }
        public List<DefaultSchedule> added { get; set; }

        public List<DefaultSchedule> changed { get; set; }
        public List<DefaultSchedule> deleted { get; set; }
        public DefaultSchedule value { get; set; }
    }
}