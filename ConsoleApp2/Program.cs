using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileReader = new FileReader();
            var splitter = new Spliter();
            var counter = new Couner();

            var res = default(Dictionary<string, int>);

            var chars = fileReader.Read("C:\\Users\\Spark\\source\\repos\\ConsoleApp2\\ConsoleApp2\\bin\\Debug\\netcoreapp3.1\\temp.txt");
            var words = splitter.MakeWordsFromChar(chars);
            res = counter.MakeStat(words);

            FormatTable(res);

        }

        static void FormatTable(Dictionary<string, int> dict)
        {
            Console.WriteLine($"{new string(' ', 10)}{"Слово:",-18}{"Кол-во:",-18}");

            var counter = 1;

            foreach (var item in dict.Keys)
            {
                Console.WriteLine($"{counter,-10}{item,10}{dict[item],10}");
                counter++;
            }
        }
    }
}
