
using GameSalesManagment.Abstract;
using GameSalesManagment.Entities;

namespace GameSalesManagment.Concrete;

public class CampaingManager:ICampaingService
{
    public void Save(Campaing campaing)
    {
        Console.WriteLine("Campaing Saved");
    }

    public void Delete(Campaing campaing)
    {
        Console.WriteLine("Campaing Deleted");
    }

    public void Update(Campaing campaing)
    {
        Console.WriteLine("Campaing Updated");
    }
}