using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.BookMarkHistory
{
    public class History: BookMarkHistory
    {
        private IWebElement ContentType;

        private IWebElement Time;
        public void DownloadHistory()
        {
            //collect all info and save as file
        }

        public History GetHistoryByContentType(string type)
        {
            //implement some filter and return the result
            return this;
        }

        public string GetTimeOfAction<T>(T action) where T : class
        {
            return "";
        }

        public History GetHistoryByDate(DateTime date)
        {
            //implement some filter and return the result
            return this;
        }

    }
}
