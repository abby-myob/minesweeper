using System.Collections.Generic;
using System.Linq;


namespace MinesweeperLibrary
{
    public class Square
    {
        public char AdjacentMines { get; set; }
        public char InitialState { get; set; }
        
        public Square(char initialState)
        {
            InitialState = initialState;
        }

        public void Update(List<Square> neighbours)
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