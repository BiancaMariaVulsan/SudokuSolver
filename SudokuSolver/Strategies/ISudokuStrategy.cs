using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Strategies
{
    public interface ISudokuStrategy
    {
        int[,] Solve(int[,] sudokuBoard);
    }
}
