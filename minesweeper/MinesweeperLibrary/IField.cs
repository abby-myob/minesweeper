using System.Collections.Generic;

namespace MinesweeperLibrary
{
    public interface IField
    {
        void UpdateSquares();
        List<string> ToStringList();
    }
}