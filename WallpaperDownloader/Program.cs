using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RedditSharp;

namespace WallpaperDownloader
{
    class Program
    {

        public static Reddit reddit = new Reddit();

        static void Main(string[] args)
        {
            String location = "";
            getPostsFromSubreddit(location, "/r/EarthPorn");
            //getPostsFromSubreddit(location, "/r/SpacePorn");
            Console.ReadLine(); //pauses to check output
        }
        
        static void getPostsFromSubreddit(String location, String subredditName)
        {
            var subreddit = reddit.GetSubreddit(subredditName);
            WebClient myWebClient = new WebClient();
            foreach (var post in subreddit.Hot.Take(10)) //for each post in  the subreddit hot section (up to 10)
            {
                var url = post.Url;

                if (url.AbsoluteUri.Substring(0, 18).Equals("http://i.imgur.com")) //if it is an imgur link
                {
                    String filename = url.AbsolutePath.Substring(1);
                }

                
                
                
            }
        }
    }
}
