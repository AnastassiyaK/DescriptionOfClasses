using ObjectDescription.TutorialNavigator.Filter;
using ObjectDescription.TutorialNavigator.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.TutorialNavigator
{
    public class TutorialNavigator
    {
        public List<TileElement> Tiles
        {
            get
            {
                //implementation of returning all tiles on the page
                return new List<TileElement>(); 

            }
        }
        public List<CurrentFilter> CurrentFilter
        {
            get
            {
                //implementation of returning all filters on the page
                return new List<CurrentFilter>();

            }
        }
    }
}
