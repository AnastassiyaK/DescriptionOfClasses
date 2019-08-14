using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.OpenSource.OpenSourceProjects
{
    public class OpenSourceProjectList
    {
        public int All
        {
            get
            {
                return 9;//return amount of all Projects(in label)
            }
        }
        public int Shown
        {
            get
            {
                return 9;//return amount of shown Projects(in label)
            }
        }

        public string InfoShowing
        {
            get
            {
                //return info at the top on the page
                return "";
            }
        }
        private List<FeatureCardContainer> Projects;

        public int GetProjectsAmount() => Projects.Count;
        public FeatureCardContainer GetProjectByTitle(string title)
        {
            //implement search
            return new FeatureCardContainer();//return found Project
        }
    }
}
