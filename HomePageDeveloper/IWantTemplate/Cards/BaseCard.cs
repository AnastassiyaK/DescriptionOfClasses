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
        protected string Title;
        protected string Description;

        public BaseCard GetCardByTitle(string title)
        {
            //find card by title and return
            return new BaseCard();
        }
    }
}
