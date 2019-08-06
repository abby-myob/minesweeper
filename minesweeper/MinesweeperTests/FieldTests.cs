using System.Collections.Generic;
using MinesweeperLibrary;
using Xunit;

namespace MinesweeperTests
{
    public class FieldTests
    {
        [Fact]
        public void Check_list_of_neighbours()
        {
            char[,] input = InputSetupCharArray(4, 4);
            Field field = new Field(4,4, input);
            
            List<Square> neighbours = SquareTests.SetUpNeighbours(2);

            //Assert.Equal(neighbours, field.GetNeighbours(new Square('.')));
            Assert.Equal(SquareTests.SetUpNeighbours(2), SquareTests.SetUpNeighbours2(2));
        }

        [Fact]
        public void Check_square_array_setup()
        {
            char[,] input = InputSetupCharArray(3, 3);
            Field field = new Field(3,3, input);
            
            List<Square> neighbours = SquareTests.SetUpNeighbours(2);

            Assert.Equal(SquareArraySetup(4,4), field.Squares);
        }
        
        
        
        
        
        
        private char[,] InputSetupCharArray(int n, int m)
        {
            var input = new char[n,m];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    input[i, j] = '.';
                }
            }

            return input;
        }

        private Square[,] SquareArraySetup(int n, int m)
        {
            Square[,] squares = new Square[n,m];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    squares[i,j] = new Square('.');
                }
            }

            return squares;
        }
    }
    
} 