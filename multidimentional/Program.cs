using System;

class Program
{
    static void Main()
    {
        string[] students = { "Student A", "Student B", "Student C", "Student D" };
        int[,] studentscore = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {

            Console.WriteLine($"--- Enter scores for {students[i]} ---");

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Exam {j + 1}: ");
                studentscore[i, j] = Convert.ToInt32(Console.ReadLine());

                studentscore[i, 3] += studentscore[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("{0,-12} {1,-8} {2,-8} {3,-8} {4,-8}", "", "Exam 1", "Exam 2", "Exam 3", "Total");
        Console.WriteLine("-------------------------------------------");

        for (int i = 0; i < 4; i++)
        {

            Console.WriteLine("{0,-12} {1,-8} {2,-8} {3,-8} {4,-8}",
                $"{students[i]}",
                studentscore[i, 0],
                studentscore[i, 1],
                studentscore[i, 2],
                studentscore[i, 3]);
        }

        Console.WriteLine("-------------------------------------------");
    }
}