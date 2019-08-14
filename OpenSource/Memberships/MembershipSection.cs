using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.OpenSource.Memberships
{
    public class MembershipSection
    {
        public string Title
        {
            get
            {
                return "";//return title
            }
        }
        public string Description
        {
            get
            {
                return "";//return description
            }
        }

        private List<MembershipContainer> Memberships
        {
            get
            {
                return new List<MembershipContainer>();//return all tile from the page
            }
        }

        public int GetContainersAmount() => Memberships.Count;
        public MembershipContainer GetMembershipContainerByTitle(string title)
        {
            //implement some search
            return Memberships[0];//return needeed attribute

        }

        public List<string> GetAllMembershipLinks()
        {
            //get from Memberships all links and return List
            return new List<string>();
        }
    }
}
