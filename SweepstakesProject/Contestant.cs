using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Contestant : IContest
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int RegistrationNumber { get; set; }
        public bool isWinner = false;
        public void Notify(IContest contestant)
        {
            if (!isWinner)
            {
                UserInterface.WinnerMessage(contestant);
            }
            else
            {
                UserInterface.LoserMessage(contestant);
            }
        }
    }
}
