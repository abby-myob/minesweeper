using MinesweeperLibrary;
using Xunit;

namespace MinesweeperTests
{
    public class FieldTests
    {
        [Fact]
        public void Field_set_up()
        {
            char[,] input = new char[4,4];
            Field field = new Field(4,4,input);
            
            
        }


        [Fact]
        public void Check_list_of_neighbours()
        {
            
            
            
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