using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneOne
{
    internal class InputCollector
    {
        private List<int> inputs = new List<int>();

        public List<int> Inputs
        {
            get { return inputs; }
            set { inputs = value; }
        }

        public InputCollector() { }

        public void ReadInFile(string fileName)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(@fileName))
                {
                    foreach (var input in File.ReadLines(fileName))
                    {
                        if (int.TryParse(input, out int numToAdd))
                        {
                            inputs.Add(numToAdd);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine("The file can't be read.");
               Console.WriteLine(ex.Message);
            }
        }
        
    }
}
