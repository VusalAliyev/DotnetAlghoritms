class Program
{
    static void Main(string[] args)
    {
        // Read the number of grades
        Console.Write("Number of grades:");
        int inputGrade = int.Parse(Console.ReadLine());

        int[] grades = new int[inputGrade];

        int x = 1;
        for (int i = 0; i < inputGrade; i++)
        {
            // Read each grade
            Console.Write($"{x} number:");
            int grade = int.Parse(Console.ReadLine());

            // Round the grade if necessary
            if (grade <= 100 && grade >= 0)
            {

                if (grade >= 38 && grade % 5 >= 3)
                {
                    grade = grade + (5 - (grade % 5));
                }
            }
            else
            {
                Console.WriteLine("The grade must be less than 100 and greater than 0");
            }

            grades[i] = grade;
            x++;

        }
        Console.WriteLine();
        // Print the grades
        foreach (var grade in grades)
        {
            Console.WriteLine(grade);
        }
    }
}