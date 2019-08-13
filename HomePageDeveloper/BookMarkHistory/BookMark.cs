using ObjectDescription.HomePageDeveloper.IWantTemplate;
using ObjectDescription.TutorialNavigator.Tiles;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.BookMarkHistory
{
    public class BookMark
    {
        public string LinkBookMark;
        public string Name
        {
            get
            {
                //implement returning
                return "";
            }
        }
        public string Date
        {
            get
            {
                //implement returning
                return "";
            }
        }

        public BookmarkType Type
        {
            get
            {
                //implement returning of BookMarkType
                return BookmarkType.Tutorial;
            }
        }
        public bool BookMarkExists(string name)
        {
            //implement search
            return true;
        }
        public void RemoveBookmark()
        {
            //implement removal
        }
        public BookMark GetBookmarkByName(string name)
        {
            //implement search by name
            return this;
        }
        public enum BookmarkType
        {
            Tutorial,
            Mission,
            Group
        }
    }
}
