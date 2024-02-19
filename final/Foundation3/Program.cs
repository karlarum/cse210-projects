using System;

class Program
{
    static void Main(string[] args)
    {
        //creates at least one event of each type and sets all of their values.
        Address address1 = new Address("123 Square Street", "Square City", "UT", "USA");
        Address address2 = new Address("456 Oval Street", "Oval City", "SC", "USA");
        Address address3 = new Address("347 Diamond Street", "Diamond City", "FL", "USA");

        LectureEvent lecture = new LectureEvent(
            "Learn to Program",
            "This lecture explains why you should learn to program.",
            new DateTime(2024, 1, 10),
            new DateTime(2024, 1, 10, 12, 0, 0),
            address1,
            "Lily Lane",
            100
            );

            ReceptionEvent reception = new ReceptionEvent(
                "Wedding Reception",
                "Please join us for our wedding reception!",
                new DateTime(2024, 2, 11),
                new DateTime(2024, 2, 11, 13, 0, 0),
                address2,
                "WeddingReception@event.com"
            );

            OutdoorEvent outdoor = new OutdoorEvent(
                "Summer Barbeque",
                "Join us to celebrate the start of the summer season!",
                new DateTime(2024, 6, 20),
                new DateTime(2024, 6, 20, 11, 0, 0),
                address3,
                "Sunny"
            );

        //for event event, call each of the methods to generate the marketing messages and output their results to the screen
        Console.WriteLine("___________________");
        Console.WriteLine("Lecture Details:");
        Console.WriteLine("___________________");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("___________________");
        Console.WriteLine("Reception Details:");
        Console.WriteLine("___________________");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("___________________");
        Console.WriteLine("Outdoor Gathering Details:");
        Console.WriteLine("___________________");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine("___________________");
    }
}