// ============================================================
//  L08 · Exam patterns & common mistakes
//  Topics: off-by-one errors (< vs <=), infinite loops,
//          loop variable modified inside body, do-while vs while,
//          break vs return, accumulator not reset between calls
// ============================================================
namespace LoopsPractice.Lessons;

public static class L08_ExamPatterns
{
    public static void Run()
    {
        Console.WriteLine("--- L08 · Exam patterns ---");

        // ── TRAP 1: off-by-one ───────────────────────────────
        // for (int i = 0; i < 10; i++)   → prints 0..9  (10 numbers)
        // for (int i = 0; i <= 10; i++)  → prints 0..10 (11 numbers)
        // TODO: print exactly 5 numbers starting from 1 (use < or <=?).

        // ── TRAP 2: infinite loop ────────────────────────────
        // These would run forever — do NOT uncomment:
        // while (true) { }
        // for (int i = 0; i >= 0; i++) { }  // i always >= 0
        // int x = 0; while (x < 5) { Console.WriteLine(x); }  // x never changes
        // TODO: fix the third example (add x++ inside the loop).

        // ── TRAP 3: modifying the loop variable ───────────────
        // Changing 'i' inside the body causes unexpected jumps.
        // TODO: predict what this prints (then uncomment to check):
        // for (int i = 0; i < 6; i++)
        // {
        //     if (i == 3) i++;    // skip 3, but also skips 4?
        //     Console.WriteLine(i);
        // }

        // ── TRAP 4: return vs break in a search ──────────────
        // Inside a method: return exits the method immediately.
        // Inside Run(): break only exits the loop, code after still runs.
        // TODO: compare FindFirst (uses return) vs LoopSearch (uses break).
        int[] data = [5, 3, 8, 1, 9];
        Console.WriteLine($"FindFirst > 7: {FindFirst(data, 7)}");

        // ── TRAP 5: accumulator scope ─────────────────────────
        // The accumulator must be declared OUTSIDE the loop.
        // int sum = 0;              ← OUTSIDE  (correct)
        // for (...) { sum += n; }
        // vs.
        // for (...) { int sum = 0; sum += n; }  ← INSIDE (always resets!)
        // TODO: demonstrate with a sum of [1,2,3,4,5].

        Console.WriteLine();
    }

    // Returns the index of the first element > threshold, or -1
    static int FindFirst(int[] arr, int threshold)
    {
        // TODO: loop, return i immediately when arr[i] > threshold
        //       return -1 after the loop
        return -1;
    }
}
