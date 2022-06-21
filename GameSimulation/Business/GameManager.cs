using GameSimulation.Abstract;
using GameSimulation.DataAccess;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Business
{
    class GameManager : IDataService<Game>
    {
        public void Add(Game entity)
        {
            Console.WriteLine($"{entity.GameName} added");
        }

        public void Delete(Game entity)
        {
            Console.WriteLine($"{entity.GameName} deleted");
        }

        public void Update(Game entity)
        {
            Console.WriteLine($"{entity.GameName} updated");
        }
    }
}
