using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Entities
{
    class Campaign : IEntityService
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public DateTime PeriodOfValidity { get; set; }
        public double DiscountRate { get; set; }
        public double MinimumCartAmount { get; set; }
    }
}
