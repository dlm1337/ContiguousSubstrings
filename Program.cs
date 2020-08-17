using System;
using System.Text.RegularExpressions;

class Program
    {


  
 
    static void Main(string[] args)
        {
        Console.WriteLine("Given a string of digits, output all the contiguous substrings");
        Console.WriteLine("of length n in that string in the order that they appear.");
        Console.WriteLine("Provide length n: ");
        int n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Provide a series of numbers(should atleast equal length n): ");
       
       
        string numbers = Console.ReadLine();

        string pattern = ("[^0-9]");
        Regex DigitsOnly = new Regex(pattern);
        if (!DigitsOnly.IsMatch(numbers))
        {
            if (numbers.Length >= n)
            {
                for (int x = 0; x <= numbers.Length - n; x++)
                {
                    Console.WriteLine(numbers.ToString().Substring(x, n));
                }
            }
            else
            {
                Console.WriteLine("n is larger than the series of numbers you provided.");
            }
        }
        else
        {
            Console.WriteLine("You have entered a non-numerical character.");
        }
    Console.ReadLine();
    }
}

