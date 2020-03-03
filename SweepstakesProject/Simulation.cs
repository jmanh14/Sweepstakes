using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            int managerSelection = UserInterface.ChooseManager();
            ISweepstakesManager manager = null;
            if (managerSelection == 1)
            {
                manager = new SweepstakesStackManager();
            }
            else if (managerSelection == 2)
            {
                manager = new SweepstakesQueueManager();
            }
            else
            {
                managerSelection = UserInterface.ChooseManager();
            }
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        }
    }
}
