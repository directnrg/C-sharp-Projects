using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Group10
{
    class TweetManager
    {
       
        private static Tweet[] tweets;
        private static string fileName = "tweets.txt";
        private static string jsonFileName = "tweets.json";


        static TweetManager()
        {      
            StreamReader tweetFile = new StreamReader(fileName);
            string line = tweetFile.ReadLine();

            //loop counts number of lines in the file to determine the number of objects in array
            int numberOfLines = 0;
            while (line != null)
            {
                numberOfLines++;
                line = tweetFile.ReadLine();
            }

            // array initialization
            tweets = new Tweet[numberOfLines];
            tweetFile.Close();

            //open file and populate the array
            tweetFile = new StreamReader(fileName);
            line = tweetFile.ReadLine();
            int i = 0;
            while (line != null)
            {
                Tweet tweet = Tweet.Process(line);

                tweets[i] = tweet;

                line = tweetFile.ReadLine();
                i++;
            }

            tweetFile.Close();
        }


        public static void ShowAll()
        {
            foreach (Tweet a in tweets)
            {
                Console.WriteLine(a.ToString());
            }
        }

        public static void ShowAll(string category)
        {
            foreach (Tweet a in tweets)
            {
                if (a.Category == category)
                {
                    Console.WriteLine(a.ToString());
                }
            }
        }

        public static void ConvertToJson()
        {
            StreamWriter tweetFile = new StreamWriter(jsonFileName);

            foreach (Tweet a in tweets)
            {
                string jsonTweetString = JsonSerializer.Serialize(a);

                tweetFile.WriteLine(jsonTweetString);
            }
            tweetFile.Close();
        }
    }
}
