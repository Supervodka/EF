using System;
using EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

using(ApplicationContext db = new ApplicationContext())
{
    User user1 = new User() { FirstName = " Tom", LastName = "Smith", Age = 36 };
    Console.WriteLine(user1.Name);
    db.Users.Add(user1);
    db.SaveChanges();
    Console.WriteLine(user1.Name);


}

Console.Read();