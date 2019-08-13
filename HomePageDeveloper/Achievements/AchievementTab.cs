using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.Achievements
{
    class AchievementTab
    {
        public Dictionary<AchievementDescription, ProgressCircle> Achievements => new Dictionary<AchievementDescription, ProgressCircle>(); // stores all achievements from the page

        public int AchievementsCount() => Achievements.Count;
        public int Total
        {
            get
            {
                // return total strings
                return 10;
            }
        }

        public int Completed
        {
            get
            {
                //return amount of completed achievements
                return 1;
            }
        }

        public List<Achievement> GetAllCompletedAchievements()
        {
            //retrun all Completed achievements
            return new List<Achievement>();
        }
        public List<Achievement> GetNotStartedAchievements()
        {
            //retrun not started achievements
            return new List<Achievement>();
        }


    }
}
