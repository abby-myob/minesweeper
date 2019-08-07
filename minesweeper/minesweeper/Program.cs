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
            Minesweeper minesweeper = new Minesweeper(Printer.GetInput());
            Printer printer = new Printer();
            
            minesweeper.Start();
            Printer.PrintFields(minesweeper.GetOutput());
        }
    }
}