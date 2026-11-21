// ============================================================
//  L04 · Jagged arrays
//  Topics: int[][], null rows, a[i].Length,
//          a[r][c] access, transpose, column totals, diagonal
// ============================================================
namespace ArrayPractice.Lessons;

public static class L04_JaggedArrays
{
    public static void Run()
    {
        Console.WriteLine("--- L04 · Jagged arrays ---");

        // A jagged array where rows have different lengths
    static void Run()
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9]
        ];

        // TODO: print every element using nested for loops (a[r][c])

        // TODO: compute and print the total of all elements
        Console.WriteLine($"Total: {JaggedTotal(table)}");

        // TODO: compute column sums (assume rectangular table here)
        int[] colSums = ColumnSums(table);
        Console.WriteLine("Col sums: " + string.Join(", ", colSums));

        // TODO: compute the main diagonal sum (top-left → bottom-right)
        Console.WriteLine($"Diagonal sum: {DiagonalSum(table)}");

        Console.WriteLine();
    }

    static int JaggedTotal(int[][] t)
    {
        // TODO
        return 0;
    }

    static int[] ColumnSums(int[][] t)
    {
        // TODO: for each column j, sum t[i][j] over all rows i
        return [];
    }

    static int DiagonalSum(int[][] t)
    {
        // TODO: sum t[i][i]
        return 0;
    }
}
