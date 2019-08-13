using ObjectDescription.HomePageDeveloper.Achievments;
using ObjectDescription.HomePageDeveloper.IWantTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.TutoriaComponent.TutorialListView
{
    public class TutorialStatusSection
    {
        public TutorialStats Mission;

        public TutorialStats Tutorial;

        public TutorialStats Group;

        public ProgressBar ProgressBar;

        public List<TutorialCardPartial> _unfinishedTutorials;//get list of tutorials

        public int AmountOfUnfinishedTutorials => _unfinishedTutorials.Count;

        public int GetCompletedByTypeIndex(int index)
        {
            //if Mission
            return Mission.Completed;
            //if .....
            
        }

        public int GetAllByTypeIndex(int index)
        {
            //if Mission
            return Mission.All;
            //if .....
        }     


    }
}
