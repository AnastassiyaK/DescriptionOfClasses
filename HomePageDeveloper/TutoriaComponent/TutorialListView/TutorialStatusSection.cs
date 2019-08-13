using ObjectDescription.HomePageDeveloper.IWantTemplate;
using System.Collections.Generic;

namespace ObjectDescription.HomePageDeveloper.TutoriaComponent.TutorialListView
{
    public class TutorialStatusSection
    {
        public TutorialStats Stats => new TutorialStats();
        
        public int GetCompletedByType(StatsType type)
        {
            //if Mission
            return Stats.Completed;
            //if .....
            
        }

        public int GetAllByType(StatsType type)
        {
            //if Mission
            return Stats.Completed;
            //if .....
        }

        public enum StatsType
        {
            Tutorial,
            Mission,
            Group
        }
    }
}
