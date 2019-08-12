using ObjectDescription.HomePageDeveloper.IWantTemplate.Cards;
using ObjectDescription.TutorialNavigator.Tiles;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.IWantTemplate
{
    public class TutorialCardPartial: BaseCard
    {
        private IWebElement Level;
        private IWebElement Time;
        private IWebElement BookMark;
        private IWebElement Tag;
        private IWebElement Icon;


        public TutorialCardPartial AddBookMark()
        {
            //check if book mark is not set, and add book mark
            return this;
        }

        public TutorialCardPartial DeleteBookMark()
        {
            //check if book mark is not set, and remove book mark
            return this;
        }

        public TutorialCardPartial GetTutorialCardByTitle(string title)
        {
            var card = GetCardByTitle(title);
            //get some attributes and return TutorialCard
            return new TutorialCardPartial();
        }

    }
}
