// ============================================================
//  L06 · out and ref parameters
//  Topics: ref → pass existing variable by reference (read+write),
//          out → method MUST assign before returning (write-only),
//          use case: return multiple values without tuples
// ============================================================
namespace FunctionsPractice.Lessons;

public static class L06_OutAndRef
{
    public static void Run()
    {
        Console.WriteLine("--- L06 · out and ref ---");

        // ── ref ──────────────────────────────────────────────
        // The method can read AND write the caller's variable.
        int score = 50;
        AddBonus(ref score, 10);
        Console.WriteLine($"Score after bonus: {score}");  // 60

        // ── out ──────────────────────────────────────────────
        // The method MUST assign the out variable before returning.
        // The caller does NOT need to initialise it first.
        Divide(10, 3, out int quotient, out int remainder);
        Console.WriteLine($"10 / 3 = {quotient} remainder {remainder}");

        // ── Real-world pattern: int.TryParse ─────────────────
        // TODO: use int.TryParse to safely convert "42" and "abc".
        //       Print the result or "not a number".
        // if (int.TryParse("42", out int n)) Console.WriteLine(n);
        // else Console.WriteLine("not a number");

        // TODO: implement MinMax below using out parameters.
        int[] nums = [7, 2, 9, 1, 5];
        MinMax(nums, out int min, out int max);
        Console.WriteLine($"Min: {min}  Max: {max}");

        Console.WriteLine();
    }

    static void AddBonus(ref int value, int bonus)
    {
        // TODO: value += bonus;
    }

    static void Divide(int a, int b, out int quotient, out int remainder)
    {
        // TODO: quotient = a / b;  remainder = a % b;
        quotient = 0;
        remainder = 0;
    }

    static void MinMax(int[] arr, out int min, out int max)
    {
        // TODO: loop setting min and max
        //       out variables must be assigned before the method returns
        min = 0;
        max = 0;
    }
}
