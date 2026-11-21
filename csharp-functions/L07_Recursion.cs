// ============================================================
//  L07 · Recursion
//  Topics: a method that calls itself,
//          base case (stops the recursion),
//          recursive case (calls itself with a smaller input),
//          stack overflow if base case is missing
// ============================================================
namespace FunctionsPractice.Lessons;

public static class L07_Recursion
{
    public static void Run()
    {
        Console.WriteLine("--- L07 · Recursion ---");

        // Every recursive method needs:
        //   1. Base case  → condition where we STOP and return directly
        //   2. Recursive case → call itself with a SMALLER / SIMPLER input

        // TODO: Factorial — base case: n==0 → return 1
        //                   recursive: return n * Factorial(n-1)
        Console.WriteLine($"5! = {Factorial(5)}");   // 120

        // TODO: Sum1ToN — sum of 1..n without a loop
        //       base: n==1 → return 1
        //       recursive: return n + Sum1ToN(n-1)
        Console.WriteLine($"Sum 1-5 = {Sum1ToN(5)}"); // 15

        // TODO: CountDown — print n, n-1, … 1 using recursion
        //       base: n == 0 → return (or print "Go!")
        //       recursive: Console.WriteLine(n); CountDown(n-1);
        CountDown(5);

        // TODO: Power(base, exp) — base^exp without Math.Pow
        //       base case: exp==0 → return 1
        //       recursive: return b * Power(b, exp-1)
        Console.WriteLine($"2^8 = {Power(2, 8)}");   // 256

        Console.WriteLine();
    }

    static int Factorial(int n)
    {
        // TODO: if (n == 0) return 1; return n * Factorial(n - 1);
        return 0;
    }

    static int Sum1ToN(int n)
    {
        // TODO
        return 0;
    }

    static void CountDown(int n)
    {
        // TODO
    }

    static int Power(int b, int exp)
    {
        // TODO
        return 0;
    }
}
