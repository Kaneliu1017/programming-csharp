// ============================================================
//  L06 · Nested loops
//  Topics: loop inside a loop, outer/inner counters,
//          multiplication table, triangle patterns,
//          time complexity intuition (n × m iterations)
// ============================================================
namespace LoopsPractice.Lessons;

public static class L06_NestedLoops
{
    public static void Run()
    {
        Console.WriteLine("--- L06 · Nested loops ---");

        // TODO: print a full 5×5 multiplication table.
        //       Each row on one line, values separated by '\t'.
        // for (int r = 1; r <= 5; r++)
        // {
        //     for (int c = 1; c <= 5; c++)
        //         Console.Write($"{r * c}\t");
        //     Console.WriteLine();
        // }

        // TODO: print a right-angled triangle of '*' with 5 rows.
        //       Row 1: *    Row 2: **    … Row 5: *****
        // for (int row = 1; row <= 5; row++)
        // {
        //     for (int col = 1; col <= row; col++)
        //         Console.Write("*");
        //     Console.WriteLine();
        // }

        // TODO: print the same triangle but with numbers:
        //       1
        //       1 2
        //       1 2 3   … up to row 5

        // TODO: given a 2D grid (jagged int[][]), print every element.
        int[][] grid = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        // for (int r = 0; r < grid.Length; r++)
        // {
        //     for (int c = 0; c < grid[r].Length; c++)
        //         Console.Write($"{grid[r][c]} ");
        //     Console.WriteLine();
        // }

        Console.WriteLine();
    }
}
