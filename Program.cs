using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Attendance_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> uniqueAttendees = new List<string>();
            string input;

            Console.WriteLine("Enter student names logging in (press Enter without typing to finish):");

            while (true)
            {
                Console.Write("> ");
                input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input))
                {
                    break; 
                }
               
                if (!uniqueAttendees.Exists(name =>
                name.Equals(input, StringComparison.OrdinalIgnoreCase)))
                {
                    uniqueAttendees.Add(input);
                }
            }
            uniqueAttendees.Sort((a, b) =>
           string.Compare(a, b, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"\nTotal unique attendees: {uniqueAttendees.Count}");
            Console.WriteLine("List of attendees:");
            foreach (string attendee in uniqueAttendees)
            {
                Console.WriteLine(attendee);
            }
        }
    }
}
