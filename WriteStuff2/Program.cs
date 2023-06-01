using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = File.CreateText(args[0]))
            {
                string input = Console.ReadLine();
                while (input != "")
                {
                    sw.WriteLine(input);
                    input = Console.ReadLine();
                }
            }
        }
    }
}
