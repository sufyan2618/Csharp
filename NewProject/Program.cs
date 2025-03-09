using System;
class Project
{
    public static void Main()
    {
        Console.WriteLine("Please Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        if(n%2 == 0)
        {
            Console.WriteLine("You entered an even number!");
        }
        else
        {
            Console.WriteLine("You entered on Odd number!");
        }

    }
}