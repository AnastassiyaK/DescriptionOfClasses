using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.TutorialNavigator.Tiles
{
    public class TileElement
    {
        private IWebElement TileHeader
        {
            get; //{return element.FindElement(By.CssSelector("[data-info]")); }
        }
        public int GetTutorialAmount()
        {
            return int.Parse(string.Join("", TileHeader.GetAttribute("data-info").ToString().TakeWhile(x => Char.IsDigit(x))));
        }

    }
}
