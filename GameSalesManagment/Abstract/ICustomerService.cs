using GameSalesManagment.Entities;

namespace GameSalesManagment.Abstract;

public interface ICustomerService
{
    void Save(Customer customer);
    void Delete(Customer customer);
    void Update(Customer customer);
}