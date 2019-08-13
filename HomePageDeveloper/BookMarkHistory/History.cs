using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.BookMarkHistory
{
    public class History
    {
        public string LinkHistory;
        public string Name
        {
            get
            {
                //implement returning
                return "";
            }
        }
        public ContentType Type
        {
            get
            {
                //implement returning
                return ContentType.Step;
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
        public string Time
        {
            get
            {
                //implement returning
                return "";
            }
        }

        public History GetHistoryByName(string name)
        {
            //implement returning 
            return this;
        }
        public enum ContentType
        {
            Step,
            Tutorial,
            Mission,
            Group

        }


    }
}
