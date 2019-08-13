using System.Collections.Generic;

namespace ObjectDescription.HomePageDeveloper.IWantTemplate
{
    public class IWantTemplate
    {
        public List<TutorialCardPartial> Tutorials => new List<TutorialCardPartial>(); //return all tutorial cards from the page

        public List<ProductCardPartial> Products => new List<ProductCardPartial>(); //return all tutorial cards from the page

        public List<BlueprintPartial> Blueprints => new List<BlueprintPartial>(); //return all tutorial cards from the page

        public List<DevshowcasePartial> Devshowcases => new List<DevshowcasePartial>(); //return all tutorial cards from the page
        public IWantTemplate SelectOption(string title)
        {
            //implement some selection
            return this;
        }

        public int GetAmountOfTutorialsDisplayed() => Tutorials.Count;
        public int GetAmountOfProductsDisplayed() => Products.Count;
        public int GetAmountOfTBlueprintsDisplayed() => Blueprints.Count;
        public int GetAmountOfDevshowcasesDisplayed() => Devshowcases.Count;

    }
}
