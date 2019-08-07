using System.Collections.Generic;
using System.Text;

namespace MinesweeperLibrary
{
    public class Field : IField
    {
        private Square[,] _squares;
        private readonly int _n;
        private readonly int _m; 

        public Field(int n, int m, char[,] input)
        {
            _n = n;
            _m = m;
            SetUpSquareArray(input);
        }

        private void SetUpSquareArray(char[,] input)
        {
            _squares = new Square[_n,_m];
            
            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _m; j++)
                {
                    _squares[i,j] = new Square(input[i,j]);
                }
            }
        }

        public void UpdateSquares()
        {
            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _m; j++)
                {
                    _squares[i,j].Update(GetNeighbours(i,j));
                }
            }
        }

        private IEnumerable<Square> GetNeighbours(int row, int col)
        {
            var neighbours = new List<Square>();

            for (var i = -1; i <= 1; i++)
            {
                if (row + i < 0 || row + i >= _n) continue;
                
                for (var j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;
                    if (col+j < 0 || col+j >= _m) continue;
                    
                    neighbours.Add(_squares[row+i,col+j]);
                }
            }
            return neighbours;
        }

        public List<string> ToStringList()
        {
            var stringBuilder = new StringBuilder();
            var output = new List<string>();
            
            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _m; j++)
                {
                    stringBuilder.Append(_squares[i, j].AdjacentMines);
                }

                output.Add(stringBuilder.ToString());
                stringBuilder = new StringBuilder();
            }
            
            return output;
        }
    }
}