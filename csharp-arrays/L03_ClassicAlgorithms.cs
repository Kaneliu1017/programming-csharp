// ============================================================
//  L03 · Classic array algorithms
//  Topics: sum & average (cast to double), max with position,
//          count matching a condition, linear search (return -1),
//          append (% Length), rotate left / right
// ============================================================
namespace ArrayPractice.Lessons;

public static class L03_ClassicAlgorithms
{
    public static void Run()
    {
        Console.WriteLine("--- L03 · Classic algorithms ---");

        int[] nums = [4, 9, 2, 7, 1, 8, 3];

    static void Run()
        //       average needs a (double) cast: (double)sum / nums.Length
        int sum = Sum(nums);
        double avg = Average(nums);
        Console.WriteLine($"Sum {sum}  Avg {avg:F2}");

        // TODO: find max value and its position
        (int max, int pos) = MaxWithPosition(nums);
        Console.WriteLine($"Max {max} at index {pos}");

        // TODO: count how many elements are greater than 5
        int count = CountGreaterThan(nums, 5);
        Console.WriteLine($"Count > 5: {count}");

        // TODO: search for 7; search for 99 (should return -1)
        Console.WriteLine($"Index of  7: {LinearSearch(nums, 7)}");
        Console.WriteLine($"Index of 99: {LinearSearch(nums, 99)}");

        Console.WriteLine();
    }

    static int Sum(int[] arr)
    {
        int total = 0;
        foreach (int n in arr)
        {
            total += n;
        }
        return total;
    }

    static double Average(int[] arr)
    {
        // TODO  (cast: (double)Sum(arr) / arr.Length)
        if (arr.Length == 0) return 0; // avoid division by zero
        return (double)Sum(arr) / arr.Length;  

    }

    static (int value, int index) MaxWithPosition(int[] arr)
    {
        // TODO
        int max = arr[0];
        int pos = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                pos = i;
            }
        }
        return (max, pos);
    }

    static int CountGreaterThan(int[] arr, int threshold)
    {
        int count = 0;
        foreach (int n in arr)
        {
            if (n > threshold)
            {
                count++;
            }
        }
        return count;
    }

    static int LinearSearch(int[] arr, int target)
    {
        // TODO: return index if found, -1 if not found
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}
