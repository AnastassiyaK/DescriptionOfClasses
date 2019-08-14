using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.OpenSource.OpenSourceProjects.Search
{
    public class SearchSection
    {
        public SearchSection SearchResultsByString(string searchString)
        {
            if (IsEmpty())
            {
                //insert search string into input
                //click to search
            }
            return this;
        }

        public string GetSearchingString()
        {
            //get a string from the input
            return "";
        }
        public SearchSection ClearSearch()
        {
            //clear input
            return this;
        }

        public bool IsEmpty()
        {
            //check if the input is empty
            return true;//or false
        }
    }
}
