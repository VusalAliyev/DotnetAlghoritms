public class Program
{
    public static int birthdayCakeCandles(int[] candles)
    {
        int max = 0;
        int count = 0;
        //Find Tallest Candle and get number of Tallest Candles
        foreach (int candle in candles)
        {
            if (candle > max)
            {
                max = candle;
                count = 1;
            }
            else if (candle == max)
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        //Get Child's age
        Console.Write("Age of child: ");
        int totalAge = int.Parse(Console.ReadLine());
        int[] candles = new int[totalAge];

        for (int i = 0; i < candles.Length; i++)
        {
            Console.Write($"{i + 1}. Candle Length: ");
            candles[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Number of tallest candles: " + birthdayCakeCandles(candles));
        Console.Read();
    }
}
