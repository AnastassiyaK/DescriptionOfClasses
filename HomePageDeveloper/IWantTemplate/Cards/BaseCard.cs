using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.IWantTemplate.Cards
{
    public class BaseCard
    {
        protected IWebElement Title;
        protected IWebElement Description;

        public int GetCardsAmount()
        {
            return 0; // return amount on the page
        }

        public bool CheckCardAttribute()
        {
            //check if element contains the attribute and return the result
            return true;
        }

        public void ViewAllCards()
        {
            //find element by locator and Click();
            //can return any page Tutorials,Products,ShowCases, BluePrints
        }

        public BaseCard GetCardByTitle(string title)
        {
            //find card by title and return
            return new BaseCard();
        }
    }
}
