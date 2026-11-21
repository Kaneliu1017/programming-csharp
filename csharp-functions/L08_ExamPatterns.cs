// ============================================================
//  L08 · Exam patterns & common mistakes
//  Topics: missing return path, void vs return, value vs ref,
//          stack overflow, expression-bodied methods =>,
//          local functions
// ============================================================
namespace FunctionsPractice.Lessons;

public static class L08_ExamPatterns
{
    public static void Run()
    {
        Console.WriteLine("--- L08 · Exam patterns ---");

        // ── TRAP 1: not all code paths return a value ─────────
        // static int Sign(int n)
        // {
        //     if (n > 0) return 1;
        //     if (n < 0) return -1;
        //     // ← compile error: n==0 falls off the end with no return
        // }
        // Fix: add else return 0; OR use else if + else.
        Console.WriteLine($"Sign(5)  = {Sign(5)}");
        Console.WriteLine($"Sign(-3) = {Sign(-3)}");
        Console.WriteLine($"Sign(0)  = {Sign(0)}");

        // ── TRAP 2: confusing void with a return type ─────────
        // void means "returns nothing" — you cannot do:
        //   int x = VoidMethod();   ← compile error
        // TODO: call PrintDouble(7) — it prints, it doesn't return.
        PrintDouble(7);

        // ── TRAP 3: value copy — method cannot change caller's int ──
        int n = 5;
        TrySet(n, 99);
        Console.WriteLine($"n after TrySet: {n}");   // still 5 — use ref to fix

        // ── TRAP 4: expression-bodied methods (shorthand) ─────
        // These two are identical:
        //   static int Square(int x) { return x * x; }
        //   static int Square(int x) => x * x;
        Console.WriteLine($"Square(6) = {Square(6)}");

        // ── TRAP 5: local functions ───────────────────────────
        // A method defined INSIDE another method — only visible there.
        int result = Compute(10);
        Console.WriteLine($"Compute(10) = {result}");

        Console.WriteLine();
    }

    // All paths must return
    static int Sign(int n)
    {
        // TODO: if (n>0) return 1; if (n<0) return -1; return 0;
        return 0;
    }

    static void PrintDouble(int n)
    {
        // TODO: Console.WriteLine(n * 2);
    }

    static void TrySet(int n, int newValue)
    {
        n = newValue;  // only the local copy changes
    }

    // Expression-bodied method
    static int Square(int x) => x * x;

    static int Compute(int x)
    {
        // Local function — only visible inside Compute
        int Triple(int v) => v * 3;   // TODO: try writing your own local fn

        int tripled = Triple(x);
        return tripled + 1;
    }
}
