using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.OpenSource.Attributes
{
    public class AttributeContainer
    {
        public Icon Icon
        {
            get
            {
                return new Icon();//returns icon from the page
            }
        }

        public string Title
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
