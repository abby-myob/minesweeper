using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using MinesweeperLibrary;

namespace minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Minesweeper minesweeper = new Minesweeper(CreateInput());
            Printer printer = new Printer();
            
            minesweeper.Start();
            printer.PrintFields(minesweeper.GetOutput());
        }

        private static List<string> CreateInput()
        {
            List<string> list = new List<string>();
            
            list.Add("44");
            list.Add("*...");
            list.Add("....");
            list.Add(".*..");
            list.Add("....");
            list.Add("");
            list.Add("44");
            list.Add("*...");
            list.Add("....");
            list.Add(".*..");
            list.Add("....");
            list.Add(""); 
            list.Add("00");

            return list;
        }
    }

    internal class Printer
    {

        public void PrintFields(List<List<string>> fields)
        {
            foreach (var field in fields)
            {
                var count = 1;
                Console.WriteLine($"Field {count}");
                
                foreach (var line in field)
                {
                    Console.WriteLine(line);
                }
                count++;
            }
            
        }
    }
}