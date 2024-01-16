using System;
using System.Collections.Generic;
//using Linq so I can use "max" for step three
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //create a new list with "new" keyword
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)

        {
            Console.Write("Enter a number (type 0 when finished): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //compute the sum
        int sum = 0;
        //foreach iterates over each element and stores it
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //find max number in list
        int max = numbers.Max();
        Console.WriteLine($"The max is: {max}");

    }
}