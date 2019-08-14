using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.OpenSource.OpenSourceProjects
{
    public class FeatureCardContainer
    {
        public Icon Image
        {
            get;//return image
        }
        
        public Icon BackgroundImage
        {
            get;//return background image
        }
        public string LinkViewMore
        {
            get
            {
                return "";//return link if exists
            }
        }
        public string Title
        {
            get
            {
                return "";//returns Title
            }
        }
        public string Description
        {
            get
            {
                return "";//returns Description
            }
        }
    }
}
