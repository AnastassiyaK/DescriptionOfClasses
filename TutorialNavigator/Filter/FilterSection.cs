using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.TutorialNavigator
{
    public class FilterSection
    {
        public FilterSection SelectTagByTitle(string title)
        {
            if (!IsSelected(title))
            {
                //implement selection
            }
            return this;
        }

        public FilterSection DeselectTagByTitle(string title)
        {
            if (IsSelected(title))
            {
                //implement unselection
            }
            return this;
        }

        public bool IsSelected(string title)
        {
            //check status of a tag
            return true; //or false
        }
    }
}
