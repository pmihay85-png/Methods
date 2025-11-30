using System;
using System.ComponentModel;

//Write a method that finds the biggest element of an array. Use that method to
//implement sorting in descending order.

class MethodForTheBiggestElementInTheArray
{
    static int FindBiggest(int[] array)
    {
        int thebiggest = array[0];

        foreach (int num in array)
        {
            if (num > thebiggest)
                thebiggest = num;
        }

        return thebiggest;
    }


    static void Main()
    {
        int[] numbers = { 3, 7, 2, 33, 1, 15, 4 };

        Console.WriteLine("Biggest element: " + FindBiggest(numbers));
      
    }
}
