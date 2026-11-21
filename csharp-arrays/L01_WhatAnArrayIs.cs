// ============================================================
//  L01 · What an array is
//  Topics: new T[n] defaults, collection expressions [a,b],
//          spread [..v, x], foreach, string.Join
// ============================================================
namespace ArrayPractice.Lessons;

public static class L01_WhatAnArrayIs
{
    public static void Run()
    {
        Console.WriteLine("--- L01 · What an array is ---");

        // TODO: declare an int array of length 5 using new int[5]
    static void Run()
        int[] defaults = new int[5];
        foreach (int value in defaults)
        {
            Console.WriteLine(value);
        }

        // TODO: declare an int array using a collection expression
        //       [1, 2, 3, 4, 5] and print it with string.Join.
        int[] nums = [1, 2, 3, 4, 5];
        Console.WriteLine(string.Join(",", nums));

        // TODO: use a spread expression to combine two arrays into one.
        int[] a = [1, 2];  int[] b = [3, 4];
        int[] combined = [..a, ..b];

        // TODO: print combined with string.Join(", ", combined)

        Console.WriteLine(string.Join(",", combined));
    }
}
