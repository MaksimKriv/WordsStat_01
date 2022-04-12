using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Couner
    {
        public Dictionary<string, int> MakeStat(IEnumerable<string> words)
        {
            var dict = new Dictionary<string, int>();
            var loverWords = words.Select(x => x.ToLower());

            foreach (var item in loverWords)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item] = dict[item] + 1;
                } else
                {
                    dict[item] = 1;
                }
            }

            return dict;
        }
    }
}
