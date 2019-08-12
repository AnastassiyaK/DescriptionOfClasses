using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.TutorialNavigator
{
    public class FilterSection
    {
        private T GetSection<T>() where T : new()
        {
            var section = new T();
            return section;
        }

        public TopicFilter Topic => GetSection<TopicFilter>();
        public ProductsFilter Product => GetSection<ProductsFilter>();
        public ExperienceFilter Experience => GetSection<ExperienceFilter>();
        public TypeFilter Type => GetSection<TypeFilter>();

        protected IWebElement _filterSection
        {
            get;
            //{ return element feom the page by CssSelector; }
        }
        public By GetTagLocator(string title)
        {
            return By.CssSelector($"...{title}");
        }
        public FilterSection SelectTagByTitle(string title)
        {
            GetTagLocator(title);
            //find element by locator and click();
            return this;
        }
        public FilterSection UnselectTagByTitle(string title)
        {
            //check if current tag is selected
            //unselect tag ();
            return this;
        }

        public FilterSection GetCurrentFilter()
        {
            //check selected items
            return this;
        }

        public bool CheckAllTagsDisplayed()
        {
            //check if all needed tags are displayed on the page
            return true; //return value
        }
        public int GetAmountOfSelectedTags()
        {
            //check selected filters
            return 0; //return amount
        }
        public void ClearAllFilters()
        {
            //Clear all filters;
        }

       





    }
}
