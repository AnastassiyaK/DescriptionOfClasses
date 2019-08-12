using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.BookMarkHistory
{
    public class BookMarkHistory
    {
        protected IWebElement Name;

        protected IWebElement Date;
        protected BookMarkHistory SearchByName(string name)
        {
            //implement search
            return this;
        }
        protected BookMarkHistory SortRowsInTable()
        {
            return this;
        }

        public int GetAmountOfEntries()
        {
            return 0; //return number of rows in the table
        }

    }
}
