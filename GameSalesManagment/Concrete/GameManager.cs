using GameSalesManagment.Abstract;
using GameSalesManagment.Entities;

namespace GameSalesManagment.Concrete;

public class GameManager:IGameService
{
    public void Save(Game game)
    {
        Console.WriteLine("Game saved: " + game.GameName);
    }

    public void Delete(Game game)
    {
        Console.WriteLine("Game deleted: " + game.GameName);
    }

    public void Update(Game game)
    {
        Console.WriteLine("Game updated: " + game.GameName);
    }
}