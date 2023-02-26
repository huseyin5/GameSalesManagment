using GameSalesManagment.Entities;

namespace GameSalesManagment.Abstract;

public interface ICampaingService
{
    void Save(Campaing campaing);
    void Delete(Campaing campaing);
    void Update(Campaing campaing);
}