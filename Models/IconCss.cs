using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace MVCSampleBrowser.Models
{
    public class IconCss
    {
        public string Name { get; set; }
        public string IconClass { get; set; }
        public static List<IconCss> GetIconList()
        {
            List<IconCss> icon = new List<IconCss>();
            icon.Add(new IconCss { Name = "Categorize and Move", IconClass = "mailtools categorize" });
            icon.Add(new IconCss { IconClass = "mailtools done", Name = "Done" });
            icon.Add(new IconCss { IconClass = "mailtools flag", Name = "Flag & Move" });
            icon.Add(new IconCss { IconClass = "mailtools forward", Name = "Forward" });
            icon.Add(new IconCss { IconClass = "mailtools movetofolder", Name = "Move to Folder" });
            icon.Add(new IconCss { IconClass = "mailtools newmail", Name = "New E-mail" });
            icon.Add(new IconCss { IconClass = "mailtools meeting", Name = "New Meeting" });
            icon.Add(new IconCss { IconClass = "mailtools reply", Name = "Reply & Delete" });
            return icon;
        }
    }
}