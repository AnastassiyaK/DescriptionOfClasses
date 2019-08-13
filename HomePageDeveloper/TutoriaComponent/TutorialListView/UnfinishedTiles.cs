using ObjectDescription.HomePageDeveloper.IWantTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.TutoriaComponent.TutorialListView
{
    public class UnfinishedTiles
    {
        public List<UnfinishedCard> _unfinishedTutorials => new List<UnfinishedCard>();//get list of tutorials

        public int AmountOfUnfinishedTutorials => _unfinishedTutorials.Count;

        
       
    }
}
