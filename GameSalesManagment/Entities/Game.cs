using GameSalesManagment.Abstract;

namespace GameSalesManagment.Entities;

public class Game:IEntity
{
    public int Id { get; set; }
    public string GameName { get; set; }
    public int GamePrice { get; set; }
}