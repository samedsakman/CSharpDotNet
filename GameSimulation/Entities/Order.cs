using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Entities
{
    class Order : IEntityService
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int CampaignId { get; set; }
        public Player Player { get; set; }
        public Game Game { get; set; }
        public Campaign Campaign { get; set; }
    }
}
