// ============================================================
//  L08 · Exam patterns & common mistakes
//  Topics: = vs ==, dangling else, missing break in switch,
//          bool comparisons, null checks, ?? operator
// ============================================================
namespace ConditionsPractice.Lessons;

public static class L08_ExamPatterns
{
    public static void Run()
    {
        Console.WriteLine("--- L08 · Exam patterns ---");

        // ── TRAP 1: = (assign) vs == (compare) ──────────────
        // if (x = 5)   ← compile error in C# (unlike C)
        // if (x == 5)  ← correct comparison
        // TODO: declare int x = 3. Print "five" only if x == 5.

        // ── TRAP 2: comparing booleans to true/false ─────────
        bool loggedIn = true;
        // BAD  → if (loggedIn == true)
        // GOOD → if (loggedIn)
        // BAD  → if (loggedIn == false)
        // GOOD → if (!loggedIn)
        // TODO: write both forms and print "logged in" / "not logged in"

        // ── TRAP 3: dangling else ─────────────────────────────
        // The else always belongs to the NEAREST if above it.
        // TODO: predict and print what this prints (then run to check):
        int a = 10, b = 5;
        if (a > 0)
            if (b > 10)
                Console.WriteLine("both positive and b>10");
        else
            Console.WriteLine("which if does this else belong to?");

        // ── TRAP 4: missing break in switch ──────────────────
        // In C#, fall-through between non-empty cases is a compile error.
        // Empty cases can stack (they fall through fine).
        // TODO: write a switch on int 'code'; stack cases 1 and 2 together.

        // ── TRAP 5: null check with ?? ───────────────────────
        // TODO: declare string? 'name' = null.
        //       Print name ?? "Guest"  (prints "Guest" when null)
        string? name = null;
        Console.WriteLine(name ?? "Guest");

        // TODO: declare string? 'city' = null.
        //       Use ?.ToUpper() so it doesn't throw on null.
        //       Print the result (will be null — that's fine).
        string? city = null;
        Console.WriteLine(city?.ToUpper());

        Console.WriteLine();
    }
}
