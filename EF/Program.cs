using System;
using EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

using(ApplicationContext db = new ApplicationContext())
{
    Product product1 = new Product {  Name = "Alex", Price = 300 };
    Company company1 = new Company { Name = "wfafsfawf"};
    db.AddRange(product1,company1);
    db.SaveChanges();

}

Console.Read();