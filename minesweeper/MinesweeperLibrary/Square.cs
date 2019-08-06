using System.Collections.Generic;

namespace MinesweeperLibrary
{
    public class Square
    {
        public Square(char initialState)
        {
            InitialState = initialState;
        }

        public char AdjacentMines { get; set; }
        public char InitialState { get; set; }

        public void Update(List<Square> neighbours)
        {
            throw new System.NotImplementedException();
        }
    }
}