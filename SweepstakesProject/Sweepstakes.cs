using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        public void RegisterConstestant(Contestant contestant)
        {
            contestant.FirstName = UserInterface.GetUserInputFor("first name");
            contestant.LastName = UserInterface.GetUserInputFor("last name");
            contestant.EmailAddress = UserInterface.GetUserInputFor("email address");
        }
        public Contestant PickWinner()
        {

        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
