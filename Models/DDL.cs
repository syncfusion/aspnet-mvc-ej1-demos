using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSampleBrowser.Models
{
    public class DDL
    {
        [Required(ErrorMessage = "Dropdown Textbox is Required")]
        public string ddl { get; set; }
    }
}