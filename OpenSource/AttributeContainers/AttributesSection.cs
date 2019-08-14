using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.OpenSource.Attributes
{
    public class AttributesSection
    {
        private List<AttributeContainer> Containers
        {
            get
            {
                return new List<AttributeContainer>();//return all tile from the page
            }
        }

        public int GetContainersAmount() => Containers.Count;
        public bool HasAttributesContainer()
        {
            //returns if has any attribute
            //if Attributes.Count <>0
            return true;
        }
        public AttributeContainer GetAttributeContainerByTitle(string title)
        {
            //implement some search

            return Containers[0];//return needeed attribute

        }
    }
}
