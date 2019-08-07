using System.Collections.Generic;
using System.Linq;


namespace MinesweeperLibrary
{
    public class Square
    {
        public char AdjacentMines { get; set; }
        private char InitialState { get; }
        
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
        
        
        
//        public override bool Equals(object obj)
//        {
//            return obj is Square other && (InitialState.Equals(other.InitialState) && AdjacentMines.Equals(other.AdjacentMines));
//        }
//        public override int GetHashCode()
//        {
//            unchecked
//            {
//                return (AdjacentMines.GetHashCode() * 397) ^ InitialState.GetHashCode();
//            }
//        }
    }
}