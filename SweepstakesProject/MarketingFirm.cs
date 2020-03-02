using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm
    {
        ISweepstakesManger _manager;

        public MarketingFirm(ISweepstakesManger manager)
        {
            _manager = manager;
        }

        public void CreateSweepstake()
        {

        }
    }
}
