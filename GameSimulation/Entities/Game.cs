using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Entities
{
    class Game : IEntityService
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}
