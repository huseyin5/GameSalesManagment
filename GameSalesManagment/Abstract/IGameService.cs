using GameSalesManagment.Entities;

namespace GameSalesManagment.Abstract;

public interface IGameService
{
    void Save(Game game);
    void Delete(Game game);
    void Update(Game game);
}