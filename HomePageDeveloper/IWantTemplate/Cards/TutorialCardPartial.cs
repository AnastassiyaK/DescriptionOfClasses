using ObjectDescription.HomePageDeveloper.IWantTemplate.Cards;

namespace ObjectDescription.HomePageDeveloper.IWantTemplate
{
    public class TutorialCardPartial: BaseCard
    {
        //Can be inherited from the tile element
        private string Time => "";//return time
        private bool HasBookmark => false;//return if tile has bookmark
        private string Tag => "";//return tag
        private enum Level
        {
            Beginner,
            Intermediate,
            Advanced
        }
        private enum Label
        {
            Featured,
            New
        }

        private TileIcon Icon; 


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
            //implement some search
            return new TutorialCardPartial();
        }

    }
}
