// ============================================================
//  L03 · else if chains
//  Topics: multi-branch decisions, order matters (top → down),
//          only ONE branch runs, exhaustive coverage
// ============================================================
namespace ConditionsPractice.Lessons;

public static class L03_ElseIfChains
{
    public static void Run()
    {
        Console.WriteLine("--- L03 · else if chains ---");

        // TODO: declare int 'score'.
        //       Print the letter grade:
        //       90-100 → "A",  70-89 → "B",
        //       50-69  → "C",  0-49  → "F"
        // int score = ...
        // if      (score >= 90) { ... }
        // else if (score >= 70) { ... }
        // else if (score >= 50) { ... }
        // else                  { ... }

        // TODO: declare int 'month' (1–12).
        //       Print the season:
        //       12,1,2 → "Winter"   3,4,5 → "Spring"
        //       6,7,8  → "Summer"   9,10,11 → "Autumn"
        //       Use || inside conditions.

        // TODO: declare int 'bmi' (body mass index).
        //       < 18.5 → "Underweight"
        //       < 25   → "Normal"
        //       < 30   → "Overweight"
        //       >= 30  → "Obese"

        Console.WriteLine();
    }
}
