using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.BookMarkHistory
{
    public class BookmarkTabList
    {
        public int AmountOfBookmarks
        {
            get
            {
                //return number of bookmarks
                return 0;
            }
        }

        public string InfoBookmark
        {
            get
            {
                //return info at the bottom on the page
                return "";
            }
        }

        public void RemoveAllBookmarks()
        {
            //implement removing of all bookmarks
        }

        public BookmarkTabList GetBookmarkByDate()
        {
            //implement some filter
            return this;
        }

    }
}
