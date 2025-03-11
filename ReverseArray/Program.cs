using System;

class ArrayExample
{
    public static void Main()
    {
        int[] arr = new int[15];
        Console.WriteLine("Please Enter 15 Elements for the Array: ");

        // Reading elements into the array  
        for (int i = 0; i < 15; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Reversing the array  
        for (int i = 0, j = 14; i < j; i++, j--) // Corrected loop condition  
        {
            // Swap elements at positions i and j  
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        // Displaying the reversed array  
        Console.WriteLine("Reversed Array: ");
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}