public class Program
{
    static void Main(string[] args)
    {
        static int FindBadTastingCandyChair(int prisoners, int treats, int startChair)
        {
            // The last candy will be given out to the prisoner who is "numTreats % numPrisoners" positions away from the starting chair.
            int badTastingCandyIndex = (startChair + treats - 1) % prisoners;

            // If the result is zero, the last prisoner gets the bad-tasting candy.
            if (badTastingCandyIndex == 0)
            {
                badTastingCandyIndex = prisoners;
            }

            return badTastingCandyIndex;
        }

        Console.WriteLine($"{FindBadTastingCandyChair(6, 8, 2)}. prisoner eats bad-tasting candy.");
    }
}