using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    class Sudoku
    {
        private Int16[,] grid;

        //TODO: Create constructors for different form of Sudoku initialisation (Multi-dim, Multiple, Single array)
        public Sudoku(String input)
        {
            // Create Grid
            grid = new Int16[9, 9];

            // Populate grid
            int count = 0;
            foreach (char c in input)
            {
                Int16 num = (Int16)char.GetNumericValue(c);
                int x = count / 9; // Row
                int y = count % 9; // Col
                grid[x, y] = num;
                count++;
            }
        }

        public void PrintSudoku()
        {
            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
