// ============================================================
//  L01 · for loop
//  Topics: for (init; condition; step),
//          counting up, counting down, step size,
//          loop variable scope
// ============================================================
namespace LoopsPractice.Lessons;

public static class L01_ForLoop
{
    public static void Run()
    {
        Console.WriteLine("--- L01 · for loop ---");

        // TODO: print numbers 1 to 10 on one line each.
        // for (int i = 1; i <= 10; i++) { ... }

        // TODO: print numbers 10 down to 1 (count backwards).
        // for (int i = 10; i >= 1; i--) { ... }

        // TODO: print even numbers from 2 to 20.
        // (hint: i += 2  OR  use i%2==0 inside the loop)

        // TODO: print the multiplication table for 7 (7×1 … 7×10).
        // Console.WriteLine($"7 × {i} = {7 * i}");

        // TODO: compute the sum of integers 1 to 100 using a for loop.
        //       Print the result. (should be 5050)
        int sum = 0;
        // for (int i = 1; i <= 100; i++) sum += i;
        Console.WriteLine($"Sum 1–100: {sum}");

        Console.WriteLine();
    }
}
