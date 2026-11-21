// ============================================================
//  L05 · Ternary operator  ?:
//  Topics: condition ? valueIfTrue : valueIfFalse
//          when to use ternary vs if/else,
//          nested ternary (use sparingly!)
// ============================================================
namespace ConditionsPractice.Lessons;

public static class L05_TernaryOperator
{
    public static void Run()
    {
        Console.WriteLine("--- L05 · Ternary operator ---");

        // TODO: declare int 'n'.
        //       Use ternary to store "even" or "odd" in a string,
        //       then print it.
        // string result = (n % 2 == 0) ? "even" : "odd";
        // Console.WriteLine(result);

        // TODO: declare int 'x' and 'y'.
        //       Use ternary to find and print the larger one.
        // int bigger = (x > y) ? x : y;

        // TODO: declare int 'score'.
        //       Use ternary inside Console.WriteLine to print
        //       "pass" or "fail" without storing a variable.
        // Console.WriteLine($"Result: {(score >= 50 ? "pass" : "fail")}");

        // TODO: declare int 'age'.
        //       Use a nested ternary to print:
        //       < 13 → "child"   13-17 → "teen"   >= 18 → "adult"
        //       (optional — keep it readable)
        // string group = age < 13 ? "child" : age < 18 ? "teen" : "adult";

        Console.WriteLine();
    }
}
