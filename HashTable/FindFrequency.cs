using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class FindFrequency
    {
        public static void Frequency(string[] para)
        {
            List<string> list = new List<string>(para);
            var duplicateKeys = list.GroupBy(x => x)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key);

            Console.WriteLine("The Frequency of words are :");
            foreach(var i in duplicateKeys)
            {
                int count = 0;
                foreach(var j in list)
                {
                    if((i.CompareTo(j)==0))
                    {
                        count++;
                    }
                }
                Console.WriteLine(i +":"+count);
            }
        }
    }
}
