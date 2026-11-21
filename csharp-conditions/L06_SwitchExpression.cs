// ============================================================
//  L06 · switch expression  (C# 8+)
//  Topics: variable switch { pattern => value, _ => default },
//          when guards,  is pattern matching,
//          difference from switch statement
// ============================================================
namespace ConditionsPractice.Lessons;

public static class L06_SwitchExpression
{
    public static void Run()
    {
        Console.WriteLine("--- L06 · switch expression ---");

        // TODO: declare int 'day' (1–7).
        //       Use a switch expression to get the day name string.
        //       _ => "Unknown" is the default arm.
        // string name = day switch
        // {
        //     1 => "Monday",
        //     2 => "Tuesday",
        //     ...
        //     _ => "Unknown"
        // };
        // Console.WriteLine(name);

        // TODO: declare int 'score'.
        //       Use a switch expression with 'when' guards to get the grade.
        // string grade = score switch
        // {
        //     >= 90          => "A",
        //     >= 70 and < 90 => "B",
        //     >= 50 and < 70 => "C",
        //     _              => "F"
        // };

        // TODO: declare object 'obj' — assign it an int, string or bool.
        //       Use 'is' type pattern to print what type it is.
        // string kind = obj switch
        // {
        //     int i    => $"integer {i}",
        //     string s => $"string '{s}'",
        //     bool b   => $"bool {b}",
        //     _        => "unknown type"
        // };

        // Key difference from switch statement:
        // switch statement → runs code (Console.WriteLine, assignments…)
        // switch expression → produces a VALUE, assigned to a variable

        Console.WriteLine();
    }

    // Helper — rewrite DayName from L04 as a switch expression
    static string DayName(int day)
    {
        // TODO: return day switch { 1 => "Monday", ... , _ => "Unknown" };
        return "";
    }
}
