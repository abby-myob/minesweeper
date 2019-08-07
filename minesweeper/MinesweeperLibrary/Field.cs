using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MinesweeperLibrary
{
    public class Field
    {
        private Square[,] Squares;
        private int N;
        private int M; 

        public Field(int n, int m, char[,] input)
        {
            N = n;
            M = m;
            SetUpSquareArray(input);
        }

        private void SetUpSquareArray(char[,] input)
        {
            Squares = new Square[N,M];
            
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < M; j++)
                {
                    Squares[i,j] = new Square(input[i,j]);
                }
            }
        }

        public void UpdateSquares()
        {
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < M; j++)
                {
                    Squares[i,j].Update(GetNeighbours(i,j));
                }
            }
        }

        private List<Square> GetNeighbours(int row, int col)
        {
            List<Square> neighbours = new List<Square>();

            for (var i = -1; i <= 1; i++)
            {
                if (row + i < 0 || row + i >= N) continue;
                
                for (var j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;
                    if (col+j < 0 || col+j >= M) continue;
                    
                    neighbours.Add(Squares[row+i,col+j]);
                }
            }
            return neighbours;
        }

        public List<string> ToStringList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<string> output = new List<string>();
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    stringBuilder.Append(Squares[i, j].AdjacentMines);
                }

                output.Add(stringBuilder.ToString());
                stringBuilder = new StringBuilder();
            }
            
            return output;
        }
    }
}