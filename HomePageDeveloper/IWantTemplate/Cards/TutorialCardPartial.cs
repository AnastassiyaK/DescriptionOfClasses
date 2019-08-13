using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.IWantTemplate.Cards
{
    public class TutorialCardPartial:BaseCard
    {
        public string Link => ""; //return link for single element
        public string Time => "";//return time
        public bool HasBookmark => false;//implement returning if tile has bookmark
        public List<string> Tag => new List<string>();//return tags
        public string Discription => "";//return description
        public enum Level
        {
            Beginner,
            Intermediate,
            Advanced
        }
        public enum Label
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
