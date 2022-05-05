using System;
using EF;
using System.Linq;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

using (ApplicationContext db = new ApplicationContext())
{
    User user1 = new User { Name = "Tom", Age = 40 };
    User user2 = new User { Name = "Alice", Age = 20 };

    db.Users.Add(user1);
    db.Users.Add(user2);
    db.SaveChanges();
    var users = db.Users.ToList();
    Console.WriteLine("Данные после добавления");
    foreach (User u in users)
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");

}Console.Read();