﻿using GameSalesManagment.Abstract;

namespace GameSalesManagment.Entities;

public class Customer:IEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalityId { get; set; }
    public DateTime DateOfBirth { get; set; }
}