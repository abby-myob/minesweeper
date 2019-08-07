using MinesweeperLibrary;

namespace minesweeper
{
    internal static class Program
    {
        private static void Main()
        {
            var minesweeper = new Minesweeper(Printer.GetInput());

            minesweeper.Start();
            Printer.PrintFields(minesweeper.GetOutput());
        }
    }
}