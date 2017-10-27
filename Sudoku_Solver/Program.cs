using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verify File Path

            // Read File

            ReadFile("sudoku_1.txt");
            Console.ReadLine();
        }

        static private void ReadFile(string fileName)
        {
            try
            {
                Console.WriteLine(Directory.GetCurrentDirectory());
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Thrown Reading File");
                Console.WriteLine(e.Message);
            }

        }

        private void ParseFile()
        {

        }

        private void ValidateFile()
        {

        }
    }
}
