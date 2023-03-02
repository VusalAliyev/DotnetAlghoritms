public class Program
{
    public static int squares(int a, int b)
    {
        //Check if square includes and increse number
        int count = 0;
        int i = 1;
        int square = 1;
        while (square <= b)
        {
            if (square >= a)
            {
                count++;
            }
            i++;
            square = i * i;
        }
        return count;
    }

    static void Main(string[] args)
    {
        Console.Write("Number 1: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Number 2: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write($"There are three square integers from {number1} to {number2}: {squares(number1, number2)}");
        Console.Read();
    }
}