using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulator.Abstract;

namespace GameSimulator.Concrete
{
    class CampaignManager : IOperationService
    {
        public void Add()
        {
            Console.WriteLine("campaign added");
        }

        public void Delete()
        {
            Console.WriteLine("campaign deleted");
        }

        public void Update()
        {
            Console.WriteLine("campaign updated");
        }
    }
}
