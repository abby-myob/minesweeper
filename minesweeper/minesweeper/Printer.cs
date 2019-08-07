using System;
using System.Collections.Generic;

namespace minesweeper
{
    internal class Printer
    {
        public static void PrintFields(IEnumerable<List<string>> fields)
        {
            var count = 1;
            foreach (var field in fields)
            {
                Console.WriteLine($"\nField #{count}");
                foreach (var line in field)
                {
                    Console.WriteLine(line);
                }

                count++;
            }
        }

        public static List<string> GetInput()
        {
            List<string> list = new List<string>(); 
            var line = Console.ReadLine();

            while (line != "00")
            {
                list.Add(line); 
                
                line = Console.ReadLine();
            }
            list.Add(line);

            return list;
        }

//        public static List<string> GetInputFake()
//        {
//            List<string> list = new List<string>();
//            list.Add("44");
//            list.Add("*...");
//            list.Add("....");
//            list.Add(".*..");
//            list.Add("....");
//            list.Add("");
//            list.Add("35");
//            list.Add("**...");
//            list.Add(".....");
//            list.Add(".*...");
//            list.Add("");
//            list.Add("00");
//            return list;
//        }
    }
}