using System.Collections.Generic;
using System.Data;

namespace MinesweeperLibrary
{
    public class Field
    {
        private Square[,] squares;
        private int N;
        private int M; 

        public Field(int n, int m, char[,] input)
        {
            N = n;
            M = m;
            SetUpSquareArray(input);
        }

        public void SetUpSquareArray(char[,] input)
        {
            
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