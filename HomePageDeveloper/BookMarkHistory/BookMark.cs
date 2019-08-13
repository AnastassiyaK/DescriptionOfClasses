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
        public BookMark GetBookMarkByDate(DateTime date)
        {
            //implement some filter and return the result
            return this;
        }
    }
}
