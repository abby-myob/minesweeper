using System.Collections.Generic;

namespace MinesweeperLibrary
{
    public class Minesweeper
    {
        private List<Field> Fields = new List<Field>();
        private List<List<string>> Output = new List<List<string>>();
        
        public Minesweeper(List<string> input)
        {
            SetUpFields(input);
        }

        public void Start()
        { 
            UpdateFields();
            ProduceOutput();
        }
        
        private void SetUpFields(List<string> input) // get a method pulled out of this logic
        {
            Fields = new List<Field>();
            int n = 0, m = 0, rows = 0; 
            char[,] chars = new char[0,0];

            foreach (var line in input)
            {
                if (line == "00") break;

                if (line.Length < 1) 
                {
                    Field field = new Field(n, m, chars);
                    Fields.Add(field);
                    continue;
                }

                if (int.TryParse(line, out var num) && line.Length == 2)
                {
                    n = (int)char.GetNumericValue(line[0]);
                    m = (int)char.GetNumericValue(line[1]);
                    chars = new char[n,m];
                    rows = 0;
                }
                else
                {
                    for (int i = 0; i < m; i++)
                    {
                        chars[rows, i] = line[i];
                    }
                    rows++;
                } 
            }
        }

        private void UpdateFields()
        {
            Fields.ForEach(x => x.UpdateSquares());
        }

        private void ProduceOutput()
        {  
            Fields.ForEach(x => Output.Add(x.ToStringList())); 
        } 
        
        public List<List<string>> GetOutput()
        {
            return Output;
        }
    }
}