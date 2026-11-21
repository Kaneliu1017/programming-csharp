// ============================================================
//  L07 · Nested conditions
//  Topics: if inside if, keeping nesting shallow (max 2–3),
//          rewriting nested ifs with && to flatten them,
//          guard clauses (early return pattern)
// ============================================================
namespace ConditionsPractice.Lessons;

public static class L07_NestedConditions
{
    public static void Run()
    {
        Console.WriteLine("--- L07 · Nested conditions ---");

        // TODO: declare bool 'hasId' and bool 'isOver18'.
        //       Using nested ifs, print:
        //       "entry allowed" only if both are true,
        //       "need ID"       if hasId is false,
        //       "too young"     if isOver18 is false (but has ID).
        // if (hasId)
        // {
        //     if (isOver18) { ... } else { ... }
        // }
        // else { ... }

        // TODO: rewrite the same logic using && to flatten it.
        // if (hasId && isOver18)      { ... }
        // else if (!hasId)            { ... }
        // else                        { ... }

        // Guard clause pattern (preferred in real code):
        // TODO: fill the body of CheckLogin below.
        string result = CheckLogin("admin", "1234");
        Console.WriteLine($"Login: {result}");

        Console.WriteLine();
    }

    // Guard clause example — return early for each failure
    static string CheckLogin(string username, string password)
    {
        // TODO: if username is empty → return "no username"
        //       if password.Length < 4 → return "password too short"
        //       if username != "admin" → return "user not found"
        //       if password != "1234"  → return "wrong password"
        //       return "welcome!"
        return "";
    }
}
