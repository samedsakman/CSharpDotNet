using GameSimulation.DataAccess;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Business
{
    class CampaignManager : IDataService<Campaign>
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine($"{entity.CampaignName} campaign added");
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine($"{entity.CampaignName} campaign deleted");
        }

        public void Update(Campaign entity)
        {
            Console.WriteLine($"{entity.CampaignName} campaign updated");
        }
    }
}
