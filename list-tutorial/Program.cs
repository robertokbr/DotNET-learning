using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {



        static void WorkingWithStrings()
        {
            var names = new List<string> { "Roberto", "Ana", "Felipe" };
            foreach (var name in names)
            {

                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //add end remove names:
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            //by position
            Console.WriteLine($" The name at position 3 is {names[3]}");

            Console.WriteLine($"how much names: {names.Count}");


            //Search array position


            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }


            //ordenation
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }


        }

        static void Main(string[] args)
        {

            // WorkingWithStrings();
           
            
            
            //return fibonaccinumbers -> 1-20

            var fibonacciNumbers = new List<int> { 1, 1 };
            for (int count=1; count<19;count++) {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);

                
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);




        }


    }

}