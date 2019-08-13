using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.Achievements
{
    public class Achievement:AchievementDescription,AchievementProgress
    {        

        public string GetAchievementDescription(int percent)
        {
            //implement some search
            return "";
        }
        public int GetAchievementProgress(int percent)
        {
            //implement some search
            return 0;
        }




    }
}
