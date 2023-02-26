using GameSalesManagment.Abstract;
using GameSalesManagment.Entities;

namespace GameSalesManagment.Concrete;

public class CustomerCheckManager:ICustomerCheckService
{
    public bool CheckReelPerfon(Customer customer)
    {
        return true;
    }
}