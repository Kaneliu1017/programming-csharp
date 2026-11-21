// ============================================================
//  L07 · Parallel arrays and tuples
//  Topics: (string Name, int Units)[] tuple arrays,
//          deconstruction (var (name, units) = arr[i]),
//          jagged arrays of tuples,
//          sorting and searching with tuples
// ============================================================
namespace ArrayPractice.Lessons;

public static class L07_ParallelArraysAndTuples
{
    public static void Run()
    {
        Console.WriteLine("--- L07 · Parallel arrays and tuples ---");

        // Parallel arrays (old style)
        string[] names   = ["Alice", "Bob", "Carol"];
        int[]    scores  = [88, 72, 95];
    static void Run()
        // TODO: print each name with its score using a for loop

        // Tuple array (modern style)
        (string Name, int Score)[] students = [
            ("Alice", 88),
            ("Bob",   72),
            ("Carol", 95)
        ];

        // TODO: print each student using deconstruction:
        //       foreach (var (name, score) in students)

        // TODO: find the student with the highest score

        // TODO: (optional) jagged array of tuples — e.g. a list of
        //       subjects per student: (string Subject, int Grade)[][]

        Console.WriteLine();
    }
}
