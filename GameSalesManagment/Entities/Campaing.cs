using GameSalesManagment.Abstract;

namespace GameSalesManagment.Entities;

public class Campaing:IEntity
{
    public int Id { get; set; }
    public string CampaingName { get; set; }
    public DateTime DeadLine { get; set; }
    public int DiscountRate { get; set; }
}