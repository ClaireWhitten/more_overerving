using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ToString
{
    class HiddenBookMark : BookMark
    {
        public override void OpenSite(string URL)
        {
            Process.Start(@"C:Program Files (x86)\Google\Chrome\Application\chrome.exe", "-incognito " + URL);
        }

        public override string ToString()
        {
            return base.ToString() + "--HIDDEN--";
        }
    }

}
