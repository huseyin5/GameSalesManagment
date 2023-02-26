using GameSalesManagment.Abstract;
using GameSalesManagment.Entities;

namespace GameSalesManagment.Concrete;

public class CustomerManager : ICustomerService
{
    private ICustomerCheckService _customerCheckService;

    public CustomerManager(ICustomerCheckService customerCheckService)
    {
        _customerCheckService = customerCheckService;
    }

    public void Save(Customer customer)
    {
        if (_customerCheckService.CheckReelPerfon(customer))
        {
            Console.WriteLine("Saved to db: " + customer.FirstName);
        }
        else
        {
            throw new Exception("Not a valid person");
        }
    }

    public void Delete(Customer customer)
    {
        Console.WriteLine("Deleted from db: " + customer.FirstName);
    }

    public void Update(Customer customer)
    {
        Console.WriteLine("Updated to db: " + customer.FirstName);
    }
}