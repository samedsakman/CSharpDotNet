using GameSimulation.Entities;
using TCKimlikNoDogrulama.Core;

namespace GameSimulation.Abstract
{
    class TcKimlikNoCheckService : INationalityIdCheckerService
    {
        public bool Check(Player player)
        {
            bool response;

            bool tcAlgoritma = new TCKimlikNoDogrulamaCORE(Convert.ToInt64(player.NationalityId), player.FirstName, player.LastName, player.YearOfBirth).TCAlgoritmasi();

            if (tcAlgoritma == false)
            {
                return false;
                
            }
            else
            {
                response = new TCKimlikNoDogrulamaCORE(Convert.ToInt64(player.NationalityId), player.FirstName, player.LastName, player.YearOfBirth).KisiVarMi();

            }
            return response;

        }
    }
}
