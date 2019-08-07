using System.Collections.Generic;
using System.Linq;


namespace MinesweeperLibrary
{
    public class Square : ISquare
    {
        public char AdjacentMines { get; private set; }
        private char InitialState { get; }
        
        public Square(char initialState)
        {
            InitialState = initialState;
        }

        public void Update(IEnumerable<Square> neighbours)
        {
            if (InitialState == '*')
            {
                AdjacentMines = InitialState;
            }
            else
            {
                AdjacentMines = char.Parse(neighbours.Count(x => x.InitialState == '*').ToString());
            }
            
            
        }
        
    }
}