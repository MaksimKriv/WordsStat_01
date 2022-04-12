using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{    class Spliter
    {
        private readonly HashSet<char> stopChars = new HashSet<char>(new[] { '.', ',', '\n','\r' , ' ' });

        public IEnumerable<string> MakeWordsFromChar(IEnumerable<char> chars)
        {
            var sb = new StringBuilder();
            
            foreach (var ch in chars)
            {
                if (stopChars.Contains(ch))
                {
                    if (sb.Length !=0)
                    {
                       yield return sb.ToString();
                       sb.Clear();
                    }
                    continue;
                }
                sb.Append(ch);
            }
        }

    }
}
