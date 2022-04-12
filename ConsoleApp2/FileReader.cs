using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class FileReader
    {    
        public IEnumerable<char> Read(String path)
        {
            using (var fo = File.OpenText(path))
            {
                var ch = fo.Read();

                while (ch != -1)
                {
                    yield return (char)ch;
                    ch = fo.Read();
                }
            }
        }
    }
}
