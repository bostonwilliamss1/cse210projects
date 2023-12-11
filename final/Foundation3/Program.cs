using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures("President Russell M. Nelson", 5000, "Jesus Christ's Atonement", "President Nelson will be speaking on the Atonement of Jesus Christ.", "05-23-2024", "7:00");
        Address addy1 = new Address("201 Salty Street", "Oakland", "Utah", "United States");

        lecture.LectureFullDetails(addy1);
        lecture.StandardDetails(addy1);
        Console.WriteLine();
        lecture.LectureShortDetails();

        Receptions reception = new Receptions("email1234@gmail.com", "Brian's House Warming Party", "Brian is celebrating a new house and wants you to join!", "08-30-2024", "5:00");
        Address addy2 = new Address("15 Park Drive", "Kettering", "Indiana", "United States");

        reception.ReceptionFullDetails(addy2);
        reception.StandardDetails(addy2);
        Console.WriteLine();
        reception.ReceptionShortDetails();

        Outdoors outdoor = new Outdoors("hot", "Sarah's BBQ", "Sarah wants to have a BBQ to celebrate being engaged!", "06-12-2024", "6:00");
        Address addy3 = new Address("145 Lincoln Park", "Beavercreek", "Massachusettes", "United States");
        outdoor.OutdoorFullDetails(addy3);
        outdoor.StandardDetails(addy3);
        Console.WriteLine();
        outdoor.OutdoorShortDetails();
    }
}