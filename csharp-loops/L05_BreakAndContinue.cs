// ============================================================
//  L05 · break and continue
//  Topics: break  → exit the loop immediately,
//          continue → skip the rest of THIS iteration and go to next,
//          using them in for, while, foreach
// ============================================================
namespace LoopsPractice.Lessons;

public static class L05_BreakAndContinue
{
    public static void Run()
    {
        Console.WriteLine("--- L05 · break and continue ---");

        // ── break ──────────────────────────────────────────────
        // TODO: search for the first negative number in an array.
        //       Break as soon as you find one. Print its index.
        int[] data = [4, 7, 2, -3, 8, -1, 0];
        // for (int i = 0; i < data.Length; i++)
        //     if (data[i] < 0) { Console.WriteLine($"First negative at {i}"); break; }

        // TODO: print numbers 1–20 but stop completely when you hit 13.
        // (use break inside a for loop)

        // ── continue ───────────────────────────────────────────
        // TODO: print only odd numbers from 1 to 15.
        //       Use continue to skip even numbers.
        // for (int i = 1; i <= 15; i++)
        // {
        //     if (i % 2 == 0) continue;
        //     Console.WriteLine(i);
        // }

        // TODO: iterate over string[] words; skip any word that
        //       starts with 'b', print the rest.
        string[] words = ["apple", "banana", "cherry", "blueberry", "date"];
        // foreach (string w in words)
        // {
        //     if (w.StartsWith('b')) continue;
        //     Console.WriteLine(w);
        // }

        // ── combined ───────────────────────────────────────────
        // TODO: find the first word longer than 5 chars in 'words'.
        //       Skip short words with continue; break when found.

        Console.WriteLine();
    }
}
