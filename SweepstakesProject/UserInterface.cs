using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        { 
            Console.Write("Enter your {0}:", prompt);
            return Console.ReadLine();
        }
        public static void GetInfoFor(Contestant contestant)
        {
            Console.WriteLine($"Name: {contestant.FirstName + " " + contestant.LastName}");
            Console.WriteLine($"Email: {contestant.EmailAddress}");
            Console.WriteLine($"Registration Number: {contestant.RegistrationNumber}");
        }
        public static string GetSweepstakeName()
        {
            string sweepstakeName;
            Console.Write("Enter the name of the Sweepstake: ");
            sweepstakeName = Console.ReadLine();
            return sweepstakeName;
        }
        public static int ChooseManager()
        { 
            Console.WriteLine("[1]Stack Manager or [2]Queue Manager");
            int answer = int.Parse(Console.ReadLine());
            return answer;

        }
    }
}
