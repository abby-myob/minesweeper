using System.Collections.Generic;
using System.Data;

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
            //for loop 
            //square.update(GetNeighbours(square));
        }

        public List<Square> GetNeighbours(Square square)
        {
            //go through squares array and put into a list
            return new List<Square>();
        }
        
    }
}