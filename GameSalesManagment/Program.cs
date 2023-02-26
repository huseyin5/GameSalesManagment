// See https://aka.ms/new-console-template for more information

using GameSalesManagment.Abstract;
using GameSalesManagment.Concrete;
using GameSalesManagment.Entities;

CustomerManager customer1 = new CustomerManager(new CustomerCheckManager());
customer1.Save(new Customer
{
    FirstName = "Hüseyin", LastName = "Mutlu", DateOfBirth = new DateTime(2001, 11, 10), NationalityId = "12345678910"
});