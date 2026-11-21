// ============================================================
//  L08 · Exam review — patterns and errors
//  Topics: nullable elements string?[],
//          IndexOutOfRangeException, NullReferenceException,
//          CS1656 (foreach loop variable is read-only),
//          Array.Sort, Array.IndexOf
// ============================================================
namespace ArrayPractice.Lessons;

public static class L08_ExamPatterns
{
    public static void Run()
    {
        Console.WriteLine("--- L08 · Exam patterns and errors ---");

        // ── Nullable array elements ──
        string?[] words = ["hello", null, "world", null, "!"];

    static void Run()

        // ── Array.Sort and Array.IndexOf ──
        int[] nums = [5, 3, 8, 1, 9, 2];
        Array.Sort(nums);
        Console.WriteLine("Sorted: " + string.Join(", ", nums));
        Console.WriteLine("Index of 8: " + Array.IndexOf(nums, 8));

        // ── Safe bounds check ──
        // TODO: write SafeGet(int[] arr, int i) below that returns
        //       the element or prints "out of range" without crashing.
        Console.WriteLine(SafeGet(nums, 2));
        Console.WriteLine(SafeGet(nums, 99));

        // ── CS1656: foreach variable is read-only ──
        // The code below does NOT compile — it is here as a reminder.
        // Uncomment to see the error, then fix it with a for loop.
        //
        // foreach (int n in nums)
        //     n += 1;   // ← CS1656: cannot assign to 'n'

        // TODO: rewrite the increment using a for loop instead

        Console.WriteLine();
    }

    static string SafeGet(int[] arr, int i)
    {
        // TODO: use try/catch IndexOutOfRangeException
        //       return the element as a string on success,
        //       "out of range" on failure.
        return "";
    }
}
