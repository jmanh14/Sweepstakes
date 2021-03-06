﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant> { };
        private string name;
        Random randomNumber = new Random();
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
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            int randomWinner = randomNumber.Next(0, contestants.Count);
            Contestant winner = new Contestant();
            winner = contestants[randomWinner];
            contestants[randomWinner].isWinner = true;
            return winner;

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.GetInfoFor(contestant);
        }
        public void NotifyContestants()
        {
            foreach (KeyValuePair<int , Contestant> contestant in contestants)
            {
                contestant.Value.Notify(contestant.Value);
            }
        }
    }
}
