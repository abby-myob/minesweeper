using System.Collections.Generic;

namespace MinesweeperLibrary
{
    public interface ISquare
    {
        char AdjacentMines { get; }
        void Update(IEnumerable<Square> neighbours);
    }
}