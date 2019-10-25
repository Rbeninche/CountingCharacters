using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello World";

            Dictionary<char, int> wordsCount = new Dictionary<char, int>();

            foreach (var item in sentence)
            {
                if (wordsCount.ContainsKey(item))
                    wordsCount[item] += 1;

                else
                    wordsCount[item] = 1;


            }


            foreach(KeyValuePair<char, int> item in wordsCount)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
                
            }
            Console.ReadLine();








        }
    }
}
