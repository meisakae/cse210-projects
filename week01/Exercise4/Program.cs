using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> number = new List<int>();
        int numbers = -1;

         Console.WriteLine("Enter a list of number, type 0 when finished.");

        while (numbers != 0)
        {
            Console.Write("Enter a number: ");
            string userinput = Console.ReadLine();
            numbers = int.Parse(userinput);
            if (numbers != 0)
            {
                number.Add(numbers);
            }
        }

        int sum = 0;
        foreach (int num in number)
        {
            sum += num;
        }
         Console.WriteLine($"This is sum is: {sum}");

        float average = ((float)sum) / number.Count;
        Console.WriteLine($"The average is: {average}");

        int max = number[0];

        foreach (int num in number)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.Write($"The max is: {max}");
    }
}