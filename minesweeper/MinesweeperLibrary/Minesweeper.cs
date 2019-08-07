using System.Collections.Generic;

namespace MinesweeperLibrary
{
    public class Minesweeper
    {
        private List<Field> Fields; 
        
        public Minesweeper(List<string> input)
        {
            SetUpFields(input);
        }

        public List<List<string>> Start()
        { 
            UpdateFields();
            return Output();
        }

        private void SetUpFields(List<string> input)
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

        private List<List<string>> Output()
        { 
            List<List<string>> output = new List<List<string>>();
            
            Fields.ForEach(x => output.Add(x.ToStringList()));
            
            return output;
        } 
    }
}