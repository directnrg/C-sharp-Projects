using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group10
{
    class Program
    {
        
        static void Main(string[] args)

        {
            //#1
            TweetManager.ShowAll();

            //#2
            Console.WriteLine($"Please insert the category of tweets you want to see: ");
            string userInput = Console.ReadLine();

            TweetManager.ShowAll(userInput);

            //#3
            TweetManager.ConvertToJson();
        }
    }
}
