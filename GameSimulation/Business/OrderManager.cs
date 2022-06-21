using GameSimulation.DataAccess;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Business
{
    class OrderManager : IDataService<Order>
    {
        public void Add(Order entity)
        {
            Console.Write($"The order of {entity.Game.GameName} game added to {entity.Player.FirstName} {entity.Player.LastName} with total order amount of {entity.Game.GamePrice}. ");
            if (entity.Campaign != null)
            {
                double discountAmount = entity.Campaign.DiscountRate * entity.Game.GamePrice;
                Console.Write($"${discountAmount} discount was applied.");
            }
            else
                Console.WriteLine();
                
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
