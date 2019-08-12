using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.TutorialNavigator.Search
{
    class SearchSection
    {
        public void SearchResultsByString(string searchString)
        {
            //browser.FindElement(By.CssSelector("input"));
            //browser.FindElement(By.CssSelector("button search")).Click();
        }

        public SearchSection ClearSearch()
        {
            //browser.FindElement(By.CssSelector("clear-input-button")).Click();
            return this;
        }
    }
}
