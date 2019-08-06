using System.Collections.Generic;
using MinesweeperLibrary;
using Xunit;

namespace MinesweeperTests
{
    public class SquareTests
    {
        [Fact]
        public void When_given_neighbours_check_new_state()
        {
            Square square = new Square('*');
            List<Square> neighbours = new List<Square>();
            
            neighbours.Add(new Square('.'));
            neighbours.Add(new Square('.'));
            neighbours.Add(new Square('.'));
            neighbours.Add(new Square('*'));
            neighbours.Add(new Square('.'));
            neighbours.Add(new Square('*'));
            neighbours.Add(new Square('.'));
            neighbours.Add(new Square('.'));

            square.Update(neighbours);
            
            Assert.Equal('2', square.AdjacentMines);
        }
    }
}

//            "44" 
//            "*..."
//            "...."
//            ".*.."
//            "...."
//                
//            "35" 
//            "**..."
//            "....."
//            ".*..."
//                
//            "00"