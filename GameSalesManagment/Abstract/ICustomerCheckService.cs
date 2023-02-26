using GameSalesManagment.Entities;

namespace GameSalesManagment.Abstract;

public interface ICustomerCheckService
{
    bool CheckReelPerfon(Customer customer);
}