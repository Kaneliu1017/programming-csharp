// ============================================================
//  L02 · while loop
//  Topics: while (condition) { },
//          when to use while vs for,
//          updating the variable inside the loop (avoid infinite)
// ============================================================
namespace LoopsPractice.Lessons;

public static class L02_WhileLoop
{
    public static void Run()
    {
        Console.WriteLine("--- L02 · while loop ---");

        // TODO: print numbers 1 to 5 using while.
        // int i = 1;
        // while (i <= 5) { Console.WriteLine(i); i++; }

        // TODO: keep halving a number (start at 256) until it is < 1.
        //       Print each step.
        // double n = 256;
        // while (n >= 1) { Console.WriteLine(n); n /= 2; }

        // TODO: countdown: start at 10, subtract 3 each step,
        //       stop when the value goes below 0.
        //       Print each value.

        // TODO: simulate reading input — use a string[] as "user input".
        //       Loop until the user types "quit":
        string[] inputs = ["hello", "world", "quit", "ignored"];
        int idx = 0;
        // while (inputs[idx] != "quit") { process inputs[idx]; idx++; }
        // Print "session ended" after the loop.

        Console.WriteLine();
    }
}
