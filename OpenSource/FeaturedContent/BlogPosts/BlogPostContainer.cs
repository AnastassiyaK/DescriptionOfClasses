using ObjectDescription.OpenSource.FeaturedContent.BlogPosts;
using ObjectDescription.OpenSource.FeaturedContent.FeedContent;
using System.Collections.Generic;

namespace ObjectDescription.OpenSource.FeaturedContent
{
    public class BlogPostContainer
    {
        public Icon Icon
        {
            get
            {
                return new Icon();//returns icon
            }
        }
        public string Topic
        {
            get
            {
                return "";//returns Type
            }
        }
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
        public BlogPostContainer GetFeedsByType(FeedType type)
        {
            //implement some search
            return this;
        }
        public FeedSortContainer GetCurrentFeedType()
        {
            //implement returning
            return new FeedSortContainer();//return current FeedType
        }


        public enum FeedType
        {
            Trending,
            Latest,
            MostLiked

        }



    }

}
