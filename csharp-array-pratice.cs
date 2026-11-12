using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        P4(); // This tells the program to execute P4
    }

    public static int[] P1()
    {
        int[] temps = [18, 21, 19, 25, 23, 17, 20];
        Console.WriteLine("Temperatures: " + string.Join(", ", temps));
        Console.WriteLine($"Monday: {temps[0]}  Sunday: {temps[^1]}  Days: {temps.Length}");
        return temps;
    }
    public static void P2()
    {
        int[] number = new int[10];
        for (int i = 0; i <= number.Length - 1; i++)
        {
            number[i] = (int)Math.Pow(i + 1, 2);
        }
        Console.WriteLine($"The number is: {string.Join(",", number)}");
    }
    public static void P3()
    {
        //it prints 0-5-0
    }

    public static void P4()
    {
        int[] temps = P1();
        int warmerCount = 0;

        for (int i = 0; i < temps.Length - 1; i++)
        {
            int diff = temps[i + 1] - temps[i];
            int dayNum = i + 2;
            if (diff > 0)
            {
                Console.WriteLine($"Day {dayNum}: Warmer by +{diff} ºC");
                warmerCount++;
            }
            else if (diff < 0)
            {
                Console.WriteLine($"Day {dayNum}: Colder by {diff}°C");
            }
            else
            {
                Console.WriteLine($"Day {dayNum}: Same as yesterday (0°C)");
            }
        }
        Console.WriteLine($"\nTotal warmer days than the day before: {warmerCount}");
        
    }
}
