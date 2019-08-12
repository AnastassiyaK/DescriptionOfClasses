using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.IWantTemplate
{
    public class IWantTemplate
    {
        private IWebElement iWantOptionsPartial
        {
            get; //return browser.FindElement(By.Id("iWantOptionsPartial"));
        }
        public By GetOptionLocator(string title)
        {
            return By.CssSelector($"...{title}");
        }
        public IWantTemplate SelectOption(string title)
        {
            GetOptionLocator(title);
            //iWantOptionsPartial.FindElements(find element by locator);
            // CLick();
            return this;
        }
    }
}
