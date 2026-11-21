// ============================================================
//  L04 · switch statement
//  Topics: switch / case / break / default,
//          multiple cases per block (fall-through label stack),
//          switch on int, string, char
// ============================================================
namespace ConditionsPractice.Lessons;

public static class L04_SwitchStatement
{
    public static void Run()
    {
        Console.WriteLine("--- L04 · switch statement ---");

        // TODO: declare int 'day' (1=Mon … 7=Sun).
        //       Use switch to print the day name.
        //       Use default for invalid numbers.
        // switch (day)
        // {
        //     case 1: Console.WriteLine("Monday"); break;
        //     case 2: ...
        //     default: Console.WriteLine("Invalid"); break;
        // }

        // TODO: declare char 'grade' ('A','B','C','D','F').
        //       Print a message for each grade.
        //       Stack cases D and F together → "Need to retake".

        // TODO: declare string 'command' ("start","stop","pause").
        //       Use switch to print what each command does.
        //       Case-insensitive: use command.ToLower() in the switch.

        Console.WriteLine();
    }

    // Helper — called from Run, fill the body
    static string DayName(int day)
    {
        // TODO: return the day name using switch, return "Unknown" for default
        return "";
    }
}
