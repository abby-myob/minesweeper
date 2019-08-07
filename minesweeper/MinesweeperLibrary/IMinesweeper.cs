using System.Collections.Generic;

namespace MinesweeperLibrary
{
    public interface IMinesweeper
    {
        void Start();
        List<List<string>> GetOutput();
    }
}