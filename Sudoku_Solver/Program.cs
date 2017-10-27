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

            string tmp = ReadFile("sudoku_1.txt");
            Sudoku sudoku = new Sudoku(tmp);
            sudoku.PrintSudoku();
            Console.ReadLine();
        }

        static private string ReadFile(string fileName)
        {
            string inputString = "";
            try
            {
                Console.WriteLine(Directory.GetCurrentDirectory());
   
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        inputString += line;
                        Console.WriteLine(line);
                    }
                }
   
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Thrown Reading File");
                Console.WriteLine(e.Message);
            }

            return inputString;
        }

        private void ParseFile()
        {

        }

        private void ValidateFile()
        {

        }
    }
}
