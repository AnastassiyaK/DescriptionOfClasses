using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDescription.OpenSource.FeaturedContent.FeedContent
{
    public class FeedContainerNotUsed
    {
        public List<FeedItem> Feeds
        {
            get
            {
                return new List<FeedItem>();//return all tile from the page
            }
        }

        public int GetFeedsAmount() => Feeds.Count;
        public FeedItem GetFeedByTitle(string title)
        {
            //implement search
            return Feeds[0];
        }
    }
}
