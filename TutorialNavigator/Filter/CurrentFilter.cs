using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.TutorialNavigator.Filter
{
    public class CurrentFilter
    {
        public CurrentFilter DeselectFilterByTag(string title)
        {
            //implement deselection of current filter
            return this;
        }
        public CurrentFilter SetClearAllFilter()
        {
            //implement selection of clear all filter
            return this;
        }

        public string GetFilterName()
        {
            //implementation
            return "";
        }
        
    }
}
