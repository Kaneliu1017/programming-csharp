// ============================================================
//  L02 · Logical operators
//  Topics: && (AND)  || (OR)  ! (NOT)
//          short-circuit evaluation, combining conditions
// ============================================================
namespace ConditionsPractice.Lessons;

public static class L02_LogicalOperators
{
    public static void Run()
    {
        Console.WriteLine("--- L02 · Logical operators ---");

        // TODO: declare int 'score' (0–100) and bool 'attended'.
        //       Print "pass" only if score >= 50 AND attended is true.
        // if (score >= 50 && attended) { ... }

        // TODO: declare int 'hour' (0–23).
        //       Print "store open" if hour >= 9 OR hour < 22.
        //       (use ||)

        // TODO: declare bool 'hasTicket'.
        //       Print "no ticket" using the ! operator.
        // if (!hasTicket) { ... }

        // TODO: declare int 'n'.
        //       Print "valid grade" if n >= 0 AND n <= 10.
        //       Print "invalid" otherwise.

        // Short-circuit note:
        // TODO: declare string? 's' = null.
        //       Use && to safely check s != null && s.Length > 3
        //       (if s is null, the second part is never evaluated)

        Console.WriteLine();
    }
}
