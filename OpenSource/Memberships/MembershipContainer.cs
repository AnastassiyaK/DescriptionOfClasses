using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.OpenSource.Memberships
{

    public class MembershipContainer
    {
        public Icon Icon
        {
            get
            {
                return new Icon();//returns icon from the page
            }
        }
        public string Link
        {
            get
            {
                return "";//returns link visit site
            }
        }

        public string Header
        {
            get
            {
                return "";//returns Title
            }
        }
        public string Description
        {
            get
            {
                return "";//returns Description
            }
        }
    }
}
