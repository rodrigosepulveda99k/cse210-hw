using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static int Menu()
    {
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Enter your choice: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void RunActivity()
    {
        int choice = Menu();
        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new();
                breathingActivity.Execute();
                break;
            case 2:
                ReflectionActivity reflectionActivity = new();
                reflectionActivity.Execute();
                break;
            case 3:
                ListingActivity listingActivity = new();
                listingActivity.Execute();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    static void Main(string[] args)
    {
        RunActivity();
    }
}
