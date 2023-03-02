public class Program
{
    public static int[] ClimbingLeaderboard(int[] ranked, int[] player)
    {
        // Remove duplicates from ranked array
        int[] distinctRanked = ranked.Distinct().ToArray();
        int n = distinctRanked.Length;
        int m = player.Length;
        int[] ranks = new int[m];
        int j = n - 1; // Pointer to the current rank
        for (int i = 0; i < m; i++)
        {
            while (j >= 0 && player[i] >= distinctRanked[j])
            {
                j--; // Move the pointer down until the player's score is higher than the rank
            }
            ranks[i] = j + 2; // Add 2 to convert the rank index to rank number (1-based)
        }
        return ranks;
    }
    static void Main(string[] args)
    {
        int[] a = new int[4];
        a[0] = 100;
        a[1] = 90;
        a[2] = 90;
        a[3] = 80;

        int[] b = new int[3];
        b[0] = 70;
        b[1] = 80;
        b[2] = 105;


        foreach (var i in ClimbingLeaderboard(a, b))
        {
            Console.WriteLine(i);
        }
        Console.Read();
    }
}