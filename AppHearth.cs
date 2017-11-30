using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace Tweetapp
{
    class AppHearth
    {
        public string Name { get; set; } //name variable automatic property

        //public string[] Tweets = new string[40];
        private string returnDefaultTweet()//make it as private - it's a logic for default timeline
        {
            string tweet = null;
            //int count = 0;
            var timelinetweets = Timeline.GetUserTimeline("apexkarthi", 30);
            foreach (var timelinetweet in timelinetweets)
            {

                tweet += timelinetweet.ToString();
                /*Tweets[count] = timelinetweet.ToString();
                count += 1;*/
                tweet += '\n';
                tweet += '\n';

            }
            /*for(int i=1; i<Tweets.Length; i++)
            {
                tweet += Tweets[i];
                tweet += '\n';
                tweet += '\n';

            }*/
            return tweet;
        }

        public string ReturnDefaultTweet //used public property to return default tweet (encapsulation)
        {
            get
            {
                return returnDefaultTweet();
            }
        }
        private string searchedTweet()
        {
            string tweet1 = null;
            var timelinetweets1 = Timeline.GetUserTimeline(Name, 30);
            foreach(var timelinetweet1 in timelinetweets1)
            {
                tweet1 += timelinetweet1.ToString();
                tweet1 += '\n';
                tweet1 += '\n';
            }
            return tweet1;
        }

        public string SearchedTweet
        {
            get
            {
                return searchedTweet();
            }
        }
    }
}
