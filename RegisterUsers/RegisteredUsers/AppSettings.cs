using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisteredUsers.Presentation
{
    public class AppSettings
    {
        public HeaderSettings HeaderSettings { get; set; }

    }
    public class HeaderSettings
    {
        public IList<TabSettings> Tabs { get; set; }

    }

    public class TabSettings
    {
        public string Title { get; set; }

        public string Url { get; set; }
        
    }
}
