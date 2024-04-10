using System;
class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Lecture St", "City1", "State1", "Country1");
        Address receptionAddress = new Address("456 Reception St", "City2", "State2", "Country2");
        Address outdoorGatheringAddress = new Address("789 Outdoor Gathering St", "City3", "State3", "Country3");

        Lecture lectureEvent = new Lecture("Lecture Title", "Lecture Description", DateTime.Now.Date, TimeSpan.Parse("14:00"), lectureAddress, "John Doe", 50);
        Reception receptionEvent = new Reception("Reception Title", "Reception Description", DateTime.Now.Date.AddDays(1), TimeSpan.Parse("18:00"), receptionAddress, "example@example.com");
        OutdoorGathering outdoorGatheringEvent = new OutdoorGathering("Outdoor Gathering Title", "Outdoor Gathering Description", DateTime.Now.Date.AddDays(2), TimeSpan.Parse("12:00"), outdoorGatheringAddress, "Sunny");

        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GenerateStandardDetails());
        Console.WriteLine(lectureEvent.GenerateFullDetails());
        Console.WriteLine(lectureEvent.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine(receptionEvent.GenerateStandardDetails());
        Console.WriteLine(receptionEvent.GenerateFullDetails());
        Console.WriteLine(receptionEvent.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine(outdoorGatheringEvent.GenerateStandardDetails());
        Console.WriteLine(outdoorGatheringEvent.GenerateFullDetails());
        Console.WriteLine(outdoorGatheringEvent.GenerateShortDescription());
    }
}
