using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWords
{
    class RandomWords
    {
        static void Main(string[] args)
        {
            List<string> inputWords = Console.ReadLine()
                                  .Split(new char[] { ' ' }
                                  , StringSplitOptions.RemoveEmptyEntries)
                                  .ToList();

            Random rand = new Random();

            //initial count of the list, so it doesnt get smaller every loop step
            //we use it as loop upper condition
            int listcount = inputWords.Count;

            for (int i = 0; i < listcount; i++)
            {
                int randomIndex = rand.Next(0, inputWords.Count - 1);
                Console.WriteLine(inputWords[randomIndex]);
                inputWords.Remove(inputWords[randomIndex]);

            }


        }
    }
}
