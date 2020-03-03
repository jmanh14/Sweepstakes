using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        public void CreateSweepstake()
        {
            string sweepstakeName = UserInterface.GetSweepstakeName();
            Sweepstakes sweepstakes = new Sweepstakes(sweepstakeName);
            _manager.InsertSweepstakes(sweepstakes);
        }
    }
}
