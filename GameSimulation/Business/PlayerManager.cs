using GameSimulation.Entities;
using GameSimulation.DataAccess;
using GameSimulation.Abstract;

namespace GameSimulation.Business;

class PlayerManager : IDataService<Player>
{
    public void Add(Player entity)
    {
        INationalityIdCheckerService tcKimlikNoCheckService = new TcKimlikNoCheckService();
        if (tcKimlikNoCheckService.Check(entity))
            Console.WriteLine($"{entity.FirstName} {entity.LastName} added");
        else
            Console.WriteLine("User is not a real person");
    }

    public void Delete(Player entity)
    {
        Console.WriteLine($"{entity.FirstName} {entity.LastName} deleted");
    }

    public void Update(Player entity)
    {
        Console.WriteLine($"{entity.FirstName} {entity.LastName} updated");
    }
}
