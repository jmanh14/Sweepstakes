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
    }
}
