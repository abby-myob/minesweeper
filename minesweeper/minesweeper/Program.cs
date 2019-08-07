using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MinesweeperLibrary;

namespace minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Minesweeper minesweeper = new Minesweeper(CreateInput());
            
            Console.WriteLine(minesweeper.Start());
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
            list.Add("00");

            return list;
        }
    }
}