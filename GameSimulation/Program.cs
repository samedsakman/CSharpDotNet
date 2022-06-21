using GameSimulation.Abstract;
using GameSimulation.Business;
using GameSimulation.Entities;

namespace GameSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INationalityIdCheckerService checkService = new TcKimlikNoCheckService();
            PlayerManager playerManager = new PlayerManager();
            Player player1 = new Player();

            player1.Id = 1;
            player1.FirstName = "Samed";
            player1.LastName = "Sakman";
            player1.NationalityId = "111111111111";
            player1.YearOfBirth = 1985;

            playerManager.Add(player1);

            Game game1 = new Game();
            game1.GameName = "Dota";
            game1.GamePrice = 100;

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Summer Discount";
            campaign1.DiscountRate = 0.3;

            Order order1 = new Order();
            order1.Game = game1;
            order1.Player = player1;
            order1.Campaign = campaign1;

            OrderManager orderManager = new OrderManager();
            orderManager.Add(order1);



            
        }
    }
}