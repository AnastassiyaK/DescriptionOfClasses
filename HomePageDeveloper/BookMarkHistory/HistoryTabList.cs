using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ObjectDescription.HomePageDeveloper.BookMarkHistory.History;

namespace ObjectDescription.HomePageDeveloper.BookMarkHistory
{
    public class HistoryTabList
    {
        public int AmountOfActionsInHistory
        {
            get
            {
                //return number of bookmarks
                return 0;
            }
        }

        public string InfoHistory
        {
            get
            {
                //return info at the bottom on the page
                return "";
            }
        }

        public HistoryTabList GetHistoryByContentType(ContentType type)
        {
            switch (type)
            {
                case ContentType.Step:
                    {
                        //implement some filter
                        return this;
                    }
                case ContentType.Group:
                    {
                        //implement some filter
                        return this;
                    }
                case ContentType.Tutorial:
                    {
                        //implement some filter
                        return this;
                    }
                case ContentType.Mission:
                    {
                        //implement some filter
                        return this;
                    }
                default: return this;

            }
        }

        public HistoryTabList GetHistoryByDate(DateTime date)
        {
            //implement some filter and return the result
            return this;
        }
        public void DownloadHistory()
        {
            //implement download
        }


    }
}
