using System.Collections.Generic;
using MinesweeperLibrary;
using Xunit;

namespace MinesweeperTests
{
    public class SquareTests
    {
        [Theory]
        [InlineData(2, '2', '.')]
        [InlineData(2, '*', '*')]
        [InlineData(8, '8', '.')]
        [InlineData(0, '0', '.')]
        [InlineData(0, '*', '*')]
        public void When_given_neighbours_update_state(int numMines, char expected, char squareState)
        {
            Square square = new Square(squareState);
            List<Square> neighbours = SetUpNeighbours(numMines);

            square.Update(neighbours);
            
            Assert.Equal(expected, square.AdjacentMines);
        }

        private List<Square> SetUpNeighbours(int numMines)
        {
            List<Square> neighbours = new List<Square>();
            
            for (int i = 0; i < numMines; i++)
            {
                neighbours.Add(new Square('*'));
            }
            
            for (int i = numMines; i < 8; i++)
            {
                neighbours.Add(new Square('.'));
            }

            return neighbours;
        }
    }
}