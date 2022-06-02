using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Group10
{
    class Tweet
    {
        private static int recentId = 1;
       
        public int Id {get; set;}
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
        public string Category { get; set; }

        public Tweet(string from, string to, string message, string category)
        {
            Id = recentId;
            From = from;
            To = to;
            Message = message;
            Category = category;

            recentId++;
        }

        public override string ToString()
        {
            //string shortmessage = Message;
            //if (shortmessage.Length > 20)
            //{
            //    shortmessage = shortmessage.Substring(0,40);
            //}
            return $" Tweet Id: {Id} \n" +
                $" From: {From} \n " +
                $"To: {To} \n" +
                $" Message: {(Message.Length >38? Message.Substring(0,38):Message)} " +
                $"\n Category: {Category} \n";
        }
        

        public static Tweet Process(string line)
        {
            
           
            string[] newTweet = line.Split(new char[] { '\t' });
            try
            { 
               if (newTweet.Length != 4)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                //return the tweet object with "Invalid" set to all properties.
                Tweet invalidTweet = new Tweet("Invalid", "Invalid", "Invalid", "Invalid");
                return invalidTweet;
            }

                string from = newTweet[0];
                string to = newTweet[1];
                string message = newTweet[2];
                string category = newTweet[3];
                Tweet userTweet = new Tweet(from, to, message,category);

                return userTweet;
        }
          
    }
}
