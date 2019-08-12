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
    public class BookMark: BookMarkHistory
    {
        private IWebElement RemoveAction;
        public List<TileElement> BookMarks
        {
            get;
            //return all Tiles that have a book mark
        }

        public BookMark RemoveBookMark()
        {
            //remove Book mark from List of Tutorials
            return this;
        }
    }
}
