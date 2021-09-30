#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSampleBrowser.Models
{
    public class EditorValue
    {
        int _num = 66;
        int _cur = 66;
        int _per = 66;
        string _mask = "9998987610";
        [Required(ErrorMessage = "Numeric Textbox is Required")]
        public int number
        {
            get
            {
                return _num;
            }
            set
            {
                value = _num;
            }
        }
        [Required(ErrorMessage = "Currency Textbox is Required")]
        public int currency
        {
            get
            {
                return _cur;
            }
            set
            {
                value = _cur;
            }
        }
        [Required(ErrorMessage = "Percent Textbox is Required")]
        public int percent
        {
            get
            {
                return _per;
            }
            set
            {
                value = _per;
            }
        }
        [Required(ErrorMessage = "MaskEdit Textbox is Required")]
        public string mask
        {
            get
            {
                return _mask;
            }
            set
            {
                value = _mask;
            }
        }
    }
    public class datepicker
    {
        DateTime dt = DateTime.Now;
        [Required(ErrorMessage = "DatePicker Value is Required")]
        public DateTime datepicker1
        {
            get
            {
                return dt;
            }
            set
            {
                value = dt;
            }
        }
    }

    public class timepicker
    {        
        [Required, Range(typeof(DateTime), "01/01/2014 10:00:00", "01/01/2020 12:00:00", ErrorMessage = "Selected Time not in Range")]
        public string time { get; set; }
    }

    public class Autocmplete
    {
        public string auto = "Audi S6";
        [Required(ErrorMessage = "Autocomplete Textbox is Required")]
        public string auto1
        {
            get
            {
                return auto;
            }
            set
            {
                value = auto;
            }
        }
    }

    public class datetimepicker
    {
        String dt = DateTime.Now.ToString();
        [Required(ErrorMessage = "DateTimePicker Textbox is Required")]
        public String datetimepicker1
        {
            get
            {
                return dt;
            }
            set
            {
                value = dt;
            }
        }
    }
    public class daterangepicker
    {
        String daterange = "12/12/2018 - 12/12/2020";
        [Required(ErrorMessage = "DateRangePicker Textbox is Required")]
        public String daterangepicker1
        {
            get
            {
                return daterange;
            }
            set
            {
                value = daterange;
            }
        }
    }

}