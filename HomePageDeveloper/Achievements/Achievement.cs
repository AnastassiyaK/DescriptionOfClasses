using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.HomePageDeveloper.Achievements
{
    public class Achievement
    {        
        public string Description
        {
            get
            {
                //return description
                return "";
            }
        }

        public int Progress
        {
            get
            {
                //return progress
                return 0;
            }
        }

        public Achievement GetAchievementByTitle(string title)
        {
            //search by title and return achievement
            return this;
        }
    }
}
