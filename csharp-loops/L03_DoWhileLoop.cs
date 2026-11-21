// ============================================================
//  L03 · do-while loop
//  Topics: do { } while (condition);
//          body runs AT LEAST ONCE — key difference from while,
//          typical use: menu, input validation
// ============================================================
namespace LoopsPractice.Lessons;

public static class L03_DoWhileLoop
{
    public static void Run()
    {
        Console.WriteLine("--- L03 · do-while loop ---");

        // TODO: print "tick" at least once, then keep printing
        //       while a counter is less than 3.
        // int count = 0;
        // do { Console.WriteLine("tick"); count++; }
        // while (count < 3);

        // TODO: simulate a menu. Use a string[] as the "user choices".
        //       Show "menu shown" and read the next choice.
        //       Repeat until choice == "exit".
        //       The menu must always show at least once.
        string[] choices = ["play", "help", "exit"];
        int i = 0;
        // do {
        //     Console.WriteLine($"Menu shown. Choice: {choices[i]}");
        //     i++;
        // } while (choices[i - 1] != "exit");

        // Key difference from while:
        // while  → condition checked BEFORE the body (may never run)
        // do-while → condition checked AFTER the body (runs at least once)

        // TODO: demonstrate: set condition false from the start.
        //       while loop prints nothing; do-while prints once.
        bool condition = false;
        // while (condition) { Console.WriteLine("while body"); }   // 0 times
        // do { Console.WriteLine("do-while body"); } while (condition); // 1 time

        Console.WriteLine();
    }
}
