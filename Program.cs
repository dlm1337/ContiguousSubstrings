﻿using System;


    class Program
    {


  
 
    static void Main(string[] args)
        {
        Console.WriteLine("Given a string of digits, output all the contiguous substrings");
        Console.WriteLine("of length n in that string in the order that they appear.");
        Console.WriteLine("Provide length n: ");
        int n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Provide a series of numbers(should atleast equal length n): ");
       
       
        int numbers = Convert.ToInt32(Console.ReadLine());


        if (n <= numbers)
        {
            for(int x = 0; x <= numbers.ToString().Length - n; x++)
            {

             
                    Console.WriteLine(numbers.ToString().Substring(x, n));
         
            
            
            }
        }
        else
        {
            Console.WriteLine("You not entered a number correctly.");
        }




       
        Console.ReadLine();
        }
    }
