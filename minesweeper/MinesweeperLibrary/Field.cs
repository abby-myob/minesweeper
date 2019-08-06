using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MinesweeperLibrary
{
    public class Field
    {
        public Square[,] Squares;
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
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Squares[i,j] = new Square(input[i,j]);
                }
            }
        }

        public void UpdateSquares()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Squares[i,j].Update(GetNeighbours(i,j));
                }
            }
        }

        public List<Square> GetNeighbours(int row, int col)
        {
            List<Square> neighbours = new List<Square>();

            for (var i = -1; i <= 1; i++)
            {
                for (var j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;
                    if (row+i < 0 || row+i > N || col+j < 0 || col+j > M) continue;
                    
                    neighbours.Add(Squares[row+i,col+j]);
                }
            }
            return neighbours;
        }
        
    }
}