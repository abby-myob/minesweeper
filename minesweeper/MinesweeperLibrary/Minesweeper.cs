using System.Collections.Generic;

namespace MinesweeperLibrary
{
    public class Minesweeper : IMinesweeper
    {
        private List<Field> _fields = new List<Field>();
        private readonly List<List<string>> _output = new List<List<string>>();
        
        public Minesweeper(IEnumerable<string> input)
        {
            SetUpFields(input);
        }

        public void Start()
        { 
            UpdateFields();
            ProduceOutput();
        }
        
        private void SetUpFields(IEnumerable<string> input) // get a method pulled out of this logic
        {
            _fields = new List<Field>();
            int n = 0, m = 0, rows = 0; 
            char[,] chars = new char[0,0];

            foreach (var line in input)
            {
                if (line == "00") break;

                if (line.Length < 1) 
                {
                    Field field = new Field(n, m, chars);
                    _fields.Add(field);
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
            _fields.ForEach(x => x.UpdateSquares());
        }

        private void ProduceOutput()
        {  
            _fields.ForEach(x => _output.Add(x.ToStringList())); 
        } 
        
        public List<List<string>> GetOutput()
        {
            return _output;
        }
    }
}